﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.SportsStore.Domain.Abstract;
using Vic.SportsStore.Domain.Entities;

namespace Vic.SportsStore.Domain.Concrete
{
    public class InMemoryProductsRepository : IProductsRepository
    {
        private List<Product> _products = new List<Product>
        {
            new Product {Name = "Football", Price=25},
            new Product {Name="Surf Board", Price=179},
            new Product {Name= "Running Shoes", Price=95}
        };
        
        public IEnumerable<Product> Products
        {
            get { return _products; }
        }
    }
}
