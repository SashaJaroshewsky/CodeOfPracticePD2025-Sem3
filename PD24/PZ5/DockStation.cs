using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ5
{
    internal class DockStation<T> where T : IChargeable
    {
        private int Caunt;
        private List<T> devices;
        public DockStation(int caunt)
        {
            devices = new List<T>();
            Caunt = caunt;
        }
        public void AddDevice(T device)
        {
            if (devices.Count >= Caunt)
            {
                Console.WriteLine("Немає місця");
            }
            else
            devices.Add(device);
        }
        public void ChargeAllDevices()
        {
            foreach (var device in devices)
            {
                device.Charge();
            }
        }
    }
}
