using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.Concrete;
using DevFramework.Northwind.DataAccess.Concrete.EntityFramework;
using DevFramework.Northwind.Entities;
using DevFramework.Northwind.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevFramework.Northwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public int PageSize = 5;
        // GET: Product
        public ViewResult Index(int page = 1)
        {
            List<Product> products = _productService.GetAll();
            return View(new ProductViewModel
            {
                Products = products.Skip((page - 1) * PageSize).Take(PageSize).ToList(),
                PagingInfo = new PagingInfo
                {
                    ItemsPerPage=PageSize,
                    TotalItems=products.Count,
                    CurrentPage = page
                }
            }) ;
        }
    }
}