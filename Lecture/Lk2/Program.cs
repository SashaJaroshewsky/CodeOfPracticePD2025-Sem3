namespace Lk2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat("Мурчик");

            //myCat.Name = "Мурчик"; // Помилка: Name захищене (protected) і недоступне тут

            Dog dog = new Dog();
            //dog.Name = "Бобік"; // Помилка: Name захищене (protected) і недоступне тут

            myCat.Speak(); // Викликає метод Speak з класу Animal
            dog.Speak();   // Викликає метод Speak з класу Animal
            Console.WriteLine("=====================");
            List<Animal> animals = new List<Animal>();

            animals.Add(myCat);
            animals.Add(dog);
            foreach (var animal in animals)
            {
                animal.Speak(); // Викликає відповідний метод Speak для кожного об'єкта
            }


        }
    }
}
