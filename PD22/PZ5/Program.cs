namespace PZ5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Device myLaptop = new Laptop("MyLaptop");
            Device myPhone = new Phone("MyPhone");

            List<Device> devices = new List<Device> { myLaptop, myPhone };

            foreach (var device in devices)
            {
                //ISwitcheable switchable = (ISwitcheable)device;

                if (device is ISwitcheable switchableDevice)
                {
                    Console.WriteLine($"{switchableDevice.DeviceName} is switchable.");
                }
                else
                {
                    Console.WriteLine($"{device.Name} is not switchable.");
                }
            }

            foreach (var device in devices)
            {
                ISwitcheable? switchable = device as ISwitcheable;

                if (switchable != null)
                    Console.WriteLine($"{switchable.DeviceName} is switchable.");
                else
                    Console.WriteLine($"{device.Name} is not switchable.");

            }

            foreach (var device in devices)
            {
                if (device is Laptop laptop)
                {
                    Console.WriteLine($"{laptop.DeviceName} is Laptop.");
                }
            }
        }
    }
}
