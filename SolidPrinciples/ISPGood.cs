using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISPGood
{

    //Good Way
    //ReadProduct sınıfı sadece Client isteklerini çalıştıracak fonksiyonları içermektedir.
    public class ReadProductRepository : IReadRepository
    {
        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetList()
        {
            throw new NotImplementedException();
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public interface IReadRepository
    {
        List<Product> GetList();
        Product GetById(int id);
         
    }

    public interface IInsertRepository
    {
        
        Product Create(Product product);
        Product Update(Product product);
        Product Delete(Product product);
    }
}
