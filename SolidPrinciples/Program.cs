using System;

namespace SolidPrinciples.DIPGood
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello SOLID!");


            //SalaryCalculator salaryCalculator = new SalaryCalculator();
            //OPClBad

            //Console.WriteLine($"Low Salary : {salaryCalculator.Calculate(1000, SalaryType.Low)}");
            //Console.WriteLine($"Middle Salary : {salaryCalculator.Calculate(1000, SalaryType.Middle)}");
            //Console.WriteLine($"High Salary : {salaryCalculator.Calculate(1000, SalaryType.High)}");

            //OpClGood

            //Console.WriteLine($"Low Salary : {salaryCalculator.Calculate(1000, new LowSalaryCalculate())}");
            //Console.WriteLine($"Middle Salary : {salaryCalculator.Calculate(1000, new MiddleSalaryCalculate())}");
            //Console.WriteLine($"High Salary : {salaryCalculator.Calculate(1000, new HighSalaryCalculate())}");

            //OpClGood2


            //Console.WriteLine($"High Salary : {salaryCalculator.Calculate(1000, x => 
            //{
            //  return x * 10;

            //})}");

            //LisSubBad

            //BasePhone basePhone = new Iphone();
            //basePhone.Call();
            //basePhone.TakeFoto();

            //basePhone = new Nokia33();

            //basePhone.Call();
            //basePhone.TakeFoto();


            ////LisSubGood
            //BasePhone basePhone = new Iphone();
            //basePhone.Call();
            //((ITakePhoto)basePhone).TakeFoto();

            //basePhone = new Nokia33();

            //basePhone.Call();

            ////DıpBad

            //var ProductService = new ProductService(new ProductRepositoryFrmSqlServer());
            //ProductService.GetAll().ForEach(x => Console.WriteLine(x));

            //DıpGood

            var ProductService = new ProductService(new ProductRepositoryFrmOracleServer());
            ProductService.GetAll().ForEach(x => Console.WriteLine(x));








        }
    }
}
