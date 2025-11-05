namespace PZ5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Device myLaptop = new Laptop("MyLaptop");
            Device myLaptop2 = new Laptop("MyLaptop2");
            Device myPhone = new Phone("MyPhone");
            Device myPC = new PC("MyPC");

            List<Device> myDevices = new List<Device>();


            List<Device> devices = new List<Device> { myLaptop, myLaptop2, myPhone, myPC };

            foreach (var device in devices)
            {
                //IChargeable chargeableDevice = (IChargeable)device;
                if (device is IChargeable chargeableDevice)
                {
                    chargeableDevice.Charge();
                }
                else
                {
                    Console.WriteLine($"{device.Name} не може заряджатись");
                }
            }

            foreach (var device in devices)
            {
                IChargeable? chargeableDevice = device as IChargeable;
                if (chargeableDevice != null)
                {
                    chargeableDevice.Charge();
                }
                else
                {
                    Console.WriteLine($"{device.Name} не може заряджатись");
                }
            }

            foreach (var device in devices)
            {
                if (device is Laptop laptop)
                {
                    Console.WriteLine($"{laptop.Name} Це ноут");
                }
                else
                {
                    Console.WriteLine($"{device.Name} Це не ноут");
                }
            }

            //Device device1 = new Device();

            DockStation<Phone> dockStation  = new DockStation<Phone>(2);
            Phone phone1 = new Phone("Phone1");
            Phone phone2 = new Phone("Phone2");
            Phone phone3 = new Phone("Phone3");
            dockStation.AddDevice(phone1);
            dockStation.AddDevice(phone2);
            dockStation.AddDevice(phone3); // Перевищення ліміту

            dockStation.ChargeAllDevices();

            DockStation<Laptop> dockStation2 = new DockStation<Laptop>(1);
            Laptop laptop1 = new Laptop("Laptop1");
            Laptop laptop2 = new Laptop("Laptop2");
            dockStation2.AddDevice(laptop1);
            dockStation2.AddDevice(laptop2); // Перевищення ліміту

            dockStation2.ChargeAllDevices();
        }
    }
}
