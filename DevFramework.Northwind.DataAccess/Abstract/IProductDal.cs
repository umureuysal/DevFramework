using DevFramework.Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        Product Get(int ProductID);
        void Add(Product product);
        void Delete(int ProductID);
        void Update(Product product);
    }
}
