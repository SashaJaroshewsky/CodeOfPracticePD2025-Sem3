namespace PZ5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Device laptop = new Laptop("МійНоутбук");
            Device phone = new Phone("МійТелефон");
            Device pc = new PC("МійПК");

            List<Device> devices = new List<Device> { laptop, phone, pc };
            foreach (var device in devices)
            {
                //IChargeable chargeableDevice = (IChargeable)device;
                if (device is IChargeable chargeable)
                {
                    chargeable.Charge();
                }
                else
                {
                    Console.WriteLine($"{device.Name}: не підтримує заряджання");
                }
            }

            foreach (var device in devices)
            {
                //IChargeable chargeableDevice = (IChargeable)device;
                IChargeable? chargeable = device as IChargeable;
                if (chargeable != null)
                {
                    chargeable.Charge();
                }
                else
                {
                    Console.WriteLine($"{device.Name}: не підтримує заряджання");
                }
            }

            foreach (var device in devices)
            {
                if (device is Laptop laptop1)
                {
                    Console.WriteLine("Це ноут");
                    laptop1.Charge();
                }
                else
                {
                    Console.WriteLine("Це не ноут");
                    
                }
                Console.WriteLine(device is Laptop laptop2? $"Це ноут" : "Це не ноут");
            }
        }
    }
}
