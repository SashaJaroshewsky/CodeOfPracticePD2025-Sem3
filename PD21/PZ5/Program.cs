namespace PZ5
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Device _myLaptop = new Laptop("MyLaptop");
            Device myPhone = new Phone("MyPhone");

            List<Device> devices = new List<Device> { _myLaptop, myPhone };
            //Console.WriteLine($"Device Name: {myLaptop.Name}");
            
            ISwitchable switchableLaptop = (ISwitchable)myPhone;

            foreach (var device in devices)
            {
                if (device is ISwitchable switchable)
                {
                    Console.WriteLine($"The device {switchable.DeviceName} is switchable.");
                }
                else
                {
                    Console.WriteLine("The device is not switchable.");
                }
            }

            foreach (var device in devices)
            {
                ISwitchable? switchableDevice = device as ISwitchable;
                if (switchableDevice != null)
                {
                    Console.WriteLine($"The device {switchableDevice.DeviceName} is switchable.");
                }
                else
                {
                    Console.WriteLine("The device is not switchable.");
                }
            }

            foreach (var device in devices)
            {
                if (device is Laptop switchable)
                {
                    Console.WriteLine($"The device {switchable.DeviceName} is switchable.");
                }
                else
                {
                    Console.WriteLine("The device is not switchable.");
                }
            }

        }
    }
}
