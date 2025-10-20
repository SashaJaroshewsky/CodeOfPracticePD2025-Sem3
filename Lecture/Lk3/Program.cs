namespace Lk3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Animal myAnimal = new Animal();// Помилка: не можна створити екземпляр абстрактного класу

            //Transport transport = new Transport();

            Transport car = new Car("BMW x5");
            Transport plane = new Plane("Mriya");
            
            car.StartEngine();   // Виведе: Двигун заведено
            car.Move();   // Виведе: Автомобіль їде по дорозі
            plane.StartEngine(); // Виведе: Двигун заведено
            plane.Move(); // Виведе: Літак летить в небі
        }
    }
}
