using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product product)
        {
            using(NorthwindContext context = new NorthwindContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void Delete(int ProductID)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Remove(context.Products.FirstOrDefault(p=>p.ProductID==ProductID));
                context.SaveChanges();
            }
        }

        public Product Get(int ProductID)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.FirstOrDefault(p=>p.ProductID==ProductID);
            }
        }

        public List<Product> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList();
            }
        }

        public void Update(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                Product productToUpdate = context.Products.FirstOrDefault(p => p.ProductID == product.ProductID);
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.CategoryID = product.CategoryID;
                productToUpdate.UnitPrice = product.UnitPrice;
                productToUpdate.UnitsInStock = product.UnitsInStock;
                context.SaveChanges();
            }
        }
    }
}
