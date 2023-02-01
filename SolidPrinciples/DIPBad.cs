using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DIPBad
{
    //Bad Code


    //High level Module
   public class ProductService
    {
        //High Level Module Low level modulu tanıyor olması DIP'e aykırıdır.
        private readonly ProductRepositoryFrmSqlServer _repository;

        public ProductService(ProductRepositoryFrmSqlServer repository)
        {
            _repository = repository;
        }

        public List<string> GetAll()
        {
            return _repository.GetAll();
        }
    }

    //Low Level Module
    public class ProductRepositoryFrmSqlServer
    {
        public List<string> GetAll()
        {
            return new List<string>() { 
            "SqlServerBadCode 1",
            "SqlServerBadCode 2"
            };
        }

    }
}
