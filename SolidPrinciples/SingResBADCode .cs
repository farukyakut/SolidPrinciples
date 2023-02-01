using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingResGoodCode
{

    // İyi Kod
    //Single responsibility'e uygun bir kod örneğidir.

    //property oluşturma sınıfı
    public class Product
    {
        public int id { get; set; }
        public string Name { get; set; }

        
    }
    //Bilgileri yazdırma sınıfı
    public class ProductPresenter
    {
        public void WriteToConsole(List<Product> productList)
        {
            productList.ForEach(x =>
            {
                Console.WriteLine($"{x.id} - {x.Name}");
            });
        }
    }
    //Repo işlemlerinin yapıldığı sınıf(ekleme, silme ve Güncelleme) 
    public class ProductRepo
    {
        private static List<Product> productList = new List<Product>();

        //private olan Product sınıfnı erişilebilir hale getiriyoruz
        public List<Product> GetProducts => productList;
        public ProductRepo()
        {
            productList = new()
            {
                new() { id = 1, Name = "Araba 1" },
                new() { id = 2, Name = "Araba 2" },
                new() { id = 3, Name = "Araba 3" },
                new() { id = 4, Name = "Araba 4" },
                new() { id = 5, Name = "Araba 5" }
            };
        }

        public void SaveOrUpdate(Product product)
        {
            var hasProduct = productList.Any(x => x.id == product.id);
            if (!hasProduct)
            {
                productList.Add(product);
            }
            else
            {
                var ındex = productList.FindIndex(x => x.id == product.id);
                productList[ındex] = product;
            }
        }

        public void Delete(int id)
        {
            var hasProduct = productList.Find(x => x.id == id);
            if (hasProduct == null)
            {
                throw new Exception("Ürün Bulunamadı");
            }

            productList.Remove(hasProduct);
        }

    }
}
