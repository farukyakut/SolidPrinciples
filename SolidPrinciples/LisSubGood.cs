using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LisSubGood
{
    public interface ITakePhoto
    {
        void TakeFoto();
    }



    public abstract class BasePhone
    {
        public void Call()
        {
            Console.WriteLine("Arama Yapıldı");

        }

        
    }

    public class Iphone : BasePhone, ITakePhoto
    {
        public void TakeFoto()
        {
            Console.WriteLine("Fotoğraf Çekildi");
        }
    }
    public class Nokia33 : BasePhone
    {
        
    }
}
