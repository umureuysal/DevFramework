using DevFramework.Northwind.Entities;
using System.Collections.Generic;

namespace DevFramework.Northwind.MvcWebUI.Models
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }
        public object PagingInfo { get; set; }
    }
}