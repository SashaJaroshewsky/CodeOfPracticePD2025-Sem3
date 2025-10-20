using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lk3
{
    internal class Guitar : IPlayable//, IPlayable2
    {
        public void Play()
        {
            Console.WriteLine("Гітара грає");
        }

        //public void IPlayable2.Play()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
