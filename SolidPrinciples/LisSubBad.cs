using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LisSubBad
{
    // Kötü kod 
    // Nokia33 Fotoğraf çekme özelliği olmamasına rağmen TakeFoto() override olarak geldiği için ve için boş kalınca patlamasına sebeb oluyor. bu Liskov Substitution prensibine aykırıdır.
   
    public abstract class BasePhone
    {
        public void Call()
        {
            Console.WriteLine("Arama Yapıldı");

        }

        public abstract void TakeFoto();
    }

    public class Iphone : BasePhone
    {
        public override void TakeFoto()
        {
            Console.WriteLine("Fotoğraf Çekildi");
        }    
    }
    public class Nokia33 : BasePhone
    {
        public override void TakeFoto()
        {
            throw new NotImplementedException();
        }
    }
}
