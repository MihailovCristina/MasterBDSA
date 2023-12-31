﻿using Microsoft.SqlServer.Server;

namespace Seminar_1.Models
{
    public class Product
    {
        public Product()
        {
            Name = string.Empty;
            Author = string.Empty;
            Format = string.Empty;
            Description = string.Empty;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Format { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public string? ImagePath { get; set; }

        public static List<Product> GetAll()
        {
            var products = new List<Product>();

            products.Add(new Product { Id = 1, Name = "Product1", Description = "D1", ImagePath = "img/img1.PNG", IsAvailable = true, Price = 20 });
            products.Add(new Product { Id = 2, Name = "Product2", Description = "D2", ImagePath = "img/img2.PNG", IsAvailable = true, Price = 50 });
            products.Add(new Product { Id = 3, Name = "Product3", Description = "D3", ImagePath = "img/img3.PNG", IsAvailable = true, Price = 100 });

            return products;
        }

    }
}
