using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Polymorphism
{
    public class Kus
    {
        // erişim belirteci + niteleyici + geri dönüş tipi + adı + parametreler
        public virtual string Ot() //header 
        {
            //body (metotun ne iş yapacağını belirtir)
            return "Cik cik";
        }

 
    }

    class Karga : Kus
    {
        public override string Ot() //yeni bir metot tanımlamıyoruz. zaten tanımlanmış ve kalıtım yoluyla kendisine aktarılmış bir metodu override etme var. metodun farklı çalışmasını yeni bir body kazandırmaktır override. yukarıdaki body'yi ezip farklı bir body veriyoruz olay budur.
        {
            return "gak gak";
        }
    }

    sealed class Corvus : Karga
    {
        //buraya kargada oluşturduğumuz öt metodu buraya taşınır oradaki metot çalışır
        public override string Ot()
        {
            return "ciyak ciyak";
        }
    }

    class MuhabbetKusu : Kus
    {

    }
}
