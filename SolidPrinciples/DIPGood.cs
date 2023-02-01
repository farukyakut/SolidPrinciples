using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DIPGood
{
    //High level Module
   public class ProductService
    {
        //Good Code

        
        private readonly IRepository _repository;

        public ProductService(IRepository repository)
        {
            _repository = repository;
        }

        public List<string> GetAll()
        {
            return _repository.GetAll();
        }
    }

    //Low Level Module
    public class ProductRepositoryFrmSqlServer : IRepository
    {
        public List<string> GetAll()
        {
            return new List<string>() { 
            "SqlServerBadCode 1",
            "SqlServerBadCode 2"
            };
        }

    }

    //Low Level Module
    public class ProductRepositoryFrmOracleServer : IRepository
    {
        public List<string> GetAll()
        {
            return new List<string>() {
            "OracleServerBadCode 1",
            "OracleServerBadCode 2"
            };
        }

    }

    public interface IRepository
    {
        public List<string> GetAll();

    }
}
