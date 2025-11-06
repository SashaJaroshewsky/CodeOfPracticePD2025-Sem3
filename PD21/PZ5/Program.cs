namespace PZ5
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Device _myLaptop = new Laptop("MyLaptop");
            Device _myLaptop2 = new Laptop("WorkLaptop");
            Device _myPC = new PC("MyPC");
            Device myPhone = new Phone("MyPhone");

            List<Device> devices = new List<Device> { _myLaptop, myPhone };
            devices.Add(_myPC);
            devices.Add(_myLaptop2);

            //Console.WriteLine($"Device Name: {myLaptop.Name}");

            foreach (var device in devices)
            {
                
                //IChargeable chargeable = (IChargeable)device;
                if (device is IChargeable chargeableDevice)
                {
                    chargeableDevice.Charge();
                }
                else
                {
                    Console.WriteLine($"{device.Name} не підтримує заряджання.");
                }
            }

            foreach (var device in devices)
            {

                //IChargeable chargeable = (IChargeable)device;
                IChargeable? chargeableDevice = device as IChargeable;
                if (chargeableDevice != null)
                {
                    chargeableDevice.Charge();
                }
                else
                {
                    Console.WriteLine($"{device.Name} не підтримує заряджання.");
                }
            }

            foreach (var device in devices)
            {

                //IChargeable chargeable = (IChargeable)device;
                
                if (device is Laptop laptop)
                {
                    Console.WriteLine($"{laptop.Name} це ноутбук");
                }
                else
                {
                    Console.WriteLine($"{device.Name}Це не ноутбук");
                }
            }




            //ISwitchable switchableLaptop = (ISwitchable)myPhone;

            //foreach (var device in devices)
            //{
            //    if (device is ISwitchable switchable)
            //    {
            //        Console.WriteLine($"The device {switchable.DeviceName} is switchable.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The device is not switchable.");
            //    }
            //}

            //foreach (var device in devices)
            //{
            //    ISwitchable? switchableDevice = device as ISwitchable;
            //    if (switchableDevice != null)
            //    {
            //        Console.WriteLine($"The device {switchableDevice.DeviceName} is switchable.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The device is not switchable.");
            //    }
            //}

            //foreach (var device in devices)
            //{
            //    if (device is Laptop switchable)
            //    {
            //        Console.WriteLine($"The device {switchable.DeviceName} is switchable.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The device is not switchable.");
            //    }
            //}

        }
    }
}
