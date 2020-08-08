﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vic.SportsStore.Domain.Abstract;
using Vic.SportsStore.Domain.Concrete;

namespace Vic.SportsStore.WebApp.Controllers
{
    public class ProductController : Controller
    {
        public IProductsRepository ProductsRepository { get; set; } 
            = new InMemoryProductsRepository();
        
        public ViewResult List()
        {
            var model = ProductsRepository.Products;
            return View(model);
        }
    }
}