using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpClBad
{
    //KÖtü Kod
    // Sallry Type'e yeni bir nesne eklendiğinde  Calculate sınıfnda yeni case eklemek gerekmektedir. Bu Kod yapısını değiştirmemize sebeb olur Bu yüzden
    //Open-Closed principles solid kuralına uymaz 

    public class SalaryCalculator
    {
        internal decimal Calculate(decimal salary, SalaryType salaryType)
        {
            decimal newSalary = 0;
            switch (salaryType)
            {
                case SalaryType.Low:
                    newSalary = salary * 2;
                    break;
                case SalaryType.Middle:
                    newSalary = salary * 4;
                    break;
                case SalaryType.High:
                    newSalary = salary * 6;
                    break;
                default:
                    break;
            }
            return newSalary;
                
        }

    }
   

    enum SalaryType
    {
        Low,
        Middle,
        High
    }

}
