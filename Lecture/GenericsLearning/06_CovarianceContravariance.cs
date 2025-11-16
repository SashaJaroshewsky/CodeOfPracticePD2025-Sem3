/// <summary>
/// Коваріантність та Контраваріантність (Covariance and Contravariance)
/// 
/// Це складна, але важлива тема в дженеріках. Вона визначає, як працювати з
/// успадкуванням типів в дженеріках.
/// 
/// КОВАРІАНТНІСТЬ (Covariance) - out
/// - Дозволяє використовувати більш конкретний тип (derived) замість базового
/// - Використовується для ВИХОДУ даних (Return type)
/// - Ключове слово: out
/// - Приклад: IEnumerable<Dog> можна присвоїти IEnumerable<Animal>
/// 
/// КОНТРАВАРІАНТНІСТЬ (Contravariance) - in
/// - Дозволяє використовувати більш загальний тип (base) замість конкретного
/// - Використовується для ВХОДУ даних (Parameters)
/// - Ключове слово: in
/// - Приклад: IComparer<Animal> можна використати для IComparer<Dog>
/// 
/// ІНВАРІАНТНІСТЬ (Invariance) - за замовчуванням
/// - Можна використовувати лише точно вказаний тип
/// - List<Dog> НЕ можна присвоїти List<Animal>
/// </summary>
namespace GenericsLearning1
{
    // === Ієрархія класів для прикладів ===
    public class Animal
    {
        public string Name { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} видає звук");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} гавкає: Гав-гав!");
        }

        public void Fetch()
        {
            Console.WriteLine($"{Name} приносить палку");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} нявкає: Няв-няв!");
        }

        public void Climb()
        {
            Console.WriteLine($"{Name} лізе на дерево");
        }
    }

    // === 1. КОВАРІАНТНІСТЬ (out) ===
    // out означає, що T використовується лише як тип повернення (output)
    public interface IAnimalProducer<out T> where T : Animal
    {
        T GetAnimal();           // OK - повертаємо T
        IEnumerable<T> GetAll(); // OK - повертаємо колекцію T

        // void AddAnimal(T animal); // ПОМИЛКА! Не можна використовувати T як параметр
    }

    // Реалізація для собак
    public class DogProducer : IAnimalProducer<Dog>
    {
        private List<Dog> _dogs = new List<Dog>
        {
            new Dog { Name = "Рекс" },
            new Dog { Name = "Бобік" }
        };

        public Dog GetAnimal()
        {
            return _dogs[0];
        }

        public IEnumerable<Dog> GetAll()
        {
            return _dogs;
        }
    }

    // === 2. КОНТРАВАРІАНТНІСТЬ (in) ===
    // in означає, що T використовується лише як параметр (input)
    public interface IAnimalConsumer<in T> where T : Animal
    {
        void Process(T animal);        // OK - приймаємо T як параметр
        void ProcessMany(IEnumerable<T> animals); // OK - приймаємо колекцію T

        // T GetAnimal(); // ПОМИЛКА! Не можна повертати T
    }

    // Споживач тварин (працює з будь-якою твариною)
    public class AnimalFeeder : IAnimalConsumer<Animal>
    {
        public void Process(Animal animal)
        {
            Console.WriteLine($"Годування {animal.Name}");
        }

        public void ProcessMany(IEnumerable<Animal> animals)
        {
            foreach (var animal in animals)
            {
                Process(animal);
            }
        }
    }

    // === 3. ІНВАРІАНТНІСТЬ (за замовчуванням) ===
    // Без out або in - тип має точно співпадати
    public interface IAnimalRepository<T> where T : Animal
    {
        void Add(T animal);      // Можна приймати параметри
        T GetById(int id);       // Можна повертати значення
        List<T> GetAll();        // Можна робити обидва
    }

    // === 4. Приклади з вбудованими інтерфейсами ===
    public class BuiltInExamples
    {
        // IEnumerable<T> є коваріантним (out T)
        public void EnumerableExample()
        {
            Console.WriteLine("=== IEnumerable<T> - Коваріантність ===");

            IEnumerable<Dog> dogs = new List<Dog>
            {
                new Dog { Name = "Рекс" },
                new Dog { Name = "Бобік" }
            };

            // Коваріантність: можемо присвоїти IEnumerable<Dog> до IEnumerable<Animal>
            // Це безпечно, бо ми лише ЧИТАЄМО з колекції
            IEnumerable<Animal> animals = dogs;

            Console.WriteLine("Тварини (з коваріантного присвоєння):");
            foreach (var animal in animals)
            {
                animal.MakeSound();
            }
        }

        // IComparer<T> є контраваріантним (in T)
        public void ComparerExample()
        {
            Console.WriteLine("\n=== IComparer<T> - Контраваріантність ===");

            // Компаратор для тварин (сортує за іменем)
            IComparer<Animal> animalComparer = Comparer<Animal>.Create(
                (a1, a2) => string.Compare(a1.Name, a2.Name)
            );

            // Контраваріантність: можемо використати IComparer<Animal> для собак
            // Це безпечно, бо Dog є Animal
            IComparer<Dog> dogComparer = animalComparer;

            List<Dog> dogs = new List<Dog>
            {
                new Dog { Name = "Шарик" },
                new Dog { Name = "Бобік" },
                new Dog { Name = "Рекс" }
            };

            dogs.Sort(dogComparer);

            Console.WriteLine("Собаки після сортування:");
            dogs.ForEach(d => Console.WriteLine($"  {d.Name}"));
        }
    }

    // === 5. Практичний приклад: Factory ===
    // Коваріантний інтерфейс для фабрики
    public interface IFactory<out T>
    {
        T Create();
    }

    public class DogFactory : IFactory<Dog>
    {
        private int _counter = 0;

        public Dog Create()
        {
            _counter++;
            return new Dog { Name = $"Собака {_counter}" };
        }
    }

    // === 6. Чому List<T> НЕ є коваріантним ===
    public class InvarianceExample
    {
        public void WhyListIsInvariant()
        {
            Console.WriteLine("\n=== Чому List<T> є інваріантним ===");

            List<Dog> dogs = new List<Dog>
            {
                new Dog { Name = "Рекс" }
            };

            // ПОМИЛКА компіляції! List<Dog> НЕ можна присвоїти List<Animal>
            // List<Animal> animals = dogs; // НЕ компілюється!

            // Чому? Якби це було можливо, ми могли б додати Cat до списку собак:
            // animals.Add(new Cat { Name = "Мурчик" }); // Cat в списку Dog!
            // Dog dog = dogs[0]; // Очікуємо Dog, але отримали б Cat!

            Console.WriteLine("List<T> є інваріантним, бо дозволяє І читання, І запис");
            Console.WriteLine("Це запобігає помилкам під час виконання");

            // Але ми можемо привести до IEnumerable (коваріантний):
            IEnumerable<Animal> animals = dogs; // OK! IEnumerable лише для читання
            Console.WriteLine($"Через IEnumerable можна: {animals.First().Name}");
        }
    }

    // Клас для демонстрації
    public class CovarianceContravarianceDemo
    {
        public static void RunExamples()
        {
            Console.WriteLine("=== 1. Коваріантність (out) ===");

            // Створюємо producer для собак
            IAnimalProducer<Dog> dogProducer = new DogProducer();

            // Коваріантність: можемо присвоїти до IAnimalProducer<Animal>
            IAnimalProducer<Animal> animalProducer = dogProducer;

            Animal animal = animalProducer.GetAnimal();
            Console.WriteLine($"Отримано тварину: {animal.Name}");
            animal.MakeSound();

            Console.WriteLine("\nВсі тварини:");
            foreach (var a in animalProducer.GetAll())
            {
                a.MakeSound();
            }

            Console.WriteLine("\n=== 2. Контраваріантність (in) ===");

            // Споживач тварин
            IAnimalConsumer<Animal> animalConsumer = new AnimalFeeder();

            // Контраваріантність: можемо використати для собак
            IAnimalConsumer<Dog> dogConsumer = animalConsumer;

            Dog myDog = new Dog { Name = "Шарик" };
            dogConsumer.Process(myDog);

            Console.WriteLine("\n=== 3. Фабрика (коваріантність) ===");

            IFactory<Dog> dogFactory = new DogFactory();

            // Коваріантність: фабрика собак = фабрика тварин
            IFactory<Animal> animalFactory = dogFactory;

            Animal createdAnimal = animalFactory.Create();
            Console.WriteLine($"Створено: {createdAnimal.Name}");
            createdAnimal.MakeSound();

            // Вбудовані приклади
            BuiltInExamples builtIn = new BuiltInExamples();
            builtIn.EnumerableExample();
            builtIn.ComparerExample();

            // Інваріантність
            InvarianceExample invariance = new InvarianceExample();
            invariance.WhyListIsInvariant();

            Console.WriteLine("\n=== Підсумок ===");
            Console.WriteLine("✓ Коваріантність (out) - для виходу даних (IEnumerable<T>)");
            Console.WriteLine("✓ Контраваріантність (in) - для входу даних (IComparer<T>)");
            Console.WriteLine("✓ Інваріантність - за замовчуванням (List<T>)");
            Console.WriteLine("✓ Використовуйте правильну варіантність для безпеки типів");
        }
    }
}