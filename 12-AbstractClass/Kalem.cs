using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_AbstractClass
{
    internal abstract class Kalem
    {
        protected Kalem()
        {
        }

        public string Renk { get; set; }
        //public abstract void Yaz();

        public void Test()
        {

        }
    }

    class TukenmezKalem : Kalem
    {

    }
}
