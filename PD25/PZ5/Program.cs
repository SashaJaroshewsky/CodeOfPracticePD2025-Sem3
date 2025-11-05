namespace PZ5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop("MyLaptop");
            Laptop laptop2 = new Laptop("MyLaptop2");
            Phone phone = new Phone("MyPhone");
            PC pc = new PC("MyPC");

            List<Device> devices = new List<Device> { laptop, laptop2, phone, pc };

            foreach (var device in devices)
            {
                //IChargeable chargeableDevice = (IChargeable)device;
                if (device is IChargeable chargeableDevice)
                {
                    //IChargeable chargeableDevice = (IChargeable)device;
                    chargeableDevice.Charge();
                }
                else
                {
                    Console.WriteLine($"{device.Name} не підтримує заряджання.");
                }
            }

            Console.WriteLine("+++++++++++++++++++++");

            foreach (var device in devices)
            {
                //IChargeable chargeableDevice = (IChargeable)device;
                IChargeable chargeableDevice = device as IChargeable;
                if (chargeableDevice != null)
                {
                    //IChargeable chargeableDevice = (IChargeable)device;
                    chargeableDevice.Charge();
                }
                else
                {
                    Console.WriteLine($"{device.Name} не підтримує заряджання.");
                }
            }

            foreach (var device in devices)
            {
                if (device is Laptop laptop1)
                {
                    Console.WriteLine("Це ноутбук");
                }
                else
                {
                    Console.WriteLine("Це не ноутбук");
                }
            }

            Device device1 = new Laptop("MyLaptop3");

            Laptop laptop4 = (Laptop)device1;



        }
    }
}
