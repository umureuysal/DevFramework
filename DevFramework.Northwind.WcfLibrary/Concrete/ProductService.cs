using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.Concrete;
using DevFramework.Northwind.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.WcfLibrary.Concrete
{
    public class ProductService : IProductService
    {
        ProductManager _productManager = new ProductManager(new EfProductDal());
        public void Add(Northwind.Entities.Product product)
        {
            _productManager.Add(product);
        }

        public void Delete(int productId)
        {
            _productManager.Delete(productId);
        }

        public Northwind.Entities.Product Get(int productId)
        {
            return _productManager.Get(productId);  
        }

        public List<Northwind.Entities.Product> GetAll()
        {
            return _productManager.GetAll();
        }

        public void Update(Northwind.Entities.Product product)
        {
            _productManager.Update(product);
        }
    }
}
