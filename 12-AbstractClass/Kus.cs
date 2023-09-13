using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_AbstractClass
{
    public abstract class Kus
    {
        public abstract string Ot();

    }

    class Karga : Kus
    {
        public override string Ot()
        {
            return "gak gak";
        }
    }

    

}
