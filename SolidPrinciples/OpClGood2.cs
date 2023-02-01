using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpClGood2
{
    //İyi Kod (Delegate Kullanarak)
    //  Kolay bir şekilde nesne eklenebildiği için open-closed principle kuralına uymaktadır 

    public class SalaryCalculator
    {
       public decimal Calculate(decimal salary, Func<decimal,decimal> calculateDelegate)
        {
            return calculateDelegate(salary);
        }

    }
   
}
