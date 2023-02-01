using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISPBad
{

    //Bad Way
    //ReadProduct sınıfı sadece GetbyId ve GetLisst fonksiyonunu kullanır Geriye kalan fonksiyonlar gereksizdir.
    public class ReadProductRepository : IProductRepository
    {
        public Product Create(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetList()
        {
            throw new NotImplementedException();
        }

        public Product Update(Product product)
        {
            throw new NotImplementedException();
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public interface IProductRepository
    {
        List<Product> GetList();
        Product GetById(int id);
        Product Create(Product product);
        Product Update(Product product);
        Product Delete(Product product);
    }
}
