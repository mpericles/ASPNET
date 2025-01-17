﻿using System.Collections.Generic;
using Testing.Models;
using System;


namespace Testing
{
    //public interface IProductRepository
    public interface IProductRepository
    {
        
        public IEnumerable<Product> GetAllProducts();
        //object GetProduct(int id);
        public Product GetProductById(int id);
        public void UpdateProduct(Product product);

        public void InsertProduct(Product productToInsert);

        public IEnumerable<Category> GetCategories();

        public Product AssignCategory();

        public void DeleteProduct(Product product);

    }
}
