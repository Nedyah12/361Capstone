using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Models
{
    public class Product : IProduct
    {
       
        /*private int ProductId { get; set; }
        private int CategoryId { get; set; }
        private int SaleId { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        private string ManInfo { get; set; }
        private string Dimensions { get; set; }
        private double Weight { get; set; }
        private double Rating { get; set; }
        private string Sku { get; set; }
        private int StockCount { get; set; }*/

        private string ProductId { get; set; }
        private string CategoryId { get; set; }
        private string SaleId { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        private string ManInfo { get; set; }
        private string Dimensions { get; set; }
        private string Weight { get; set; }
        private string Rating { get; set; }
        private string Sku { get; set; }
        private string StockCount { get; set; }

        private string Price { get; set; }


        public Product(string productId, string categoryId, string saleId, string name, string desc, string manInfo, string dims, string weight, string rating, string sku, string stockCount, string price)
        {
            ProductId = productId;
            CategoryId = categoryId;
            SaleId = saleId;
            Name = name;
            Description = desc;
            ManInfo = manInfo;
            Dimensions = dims;
            Weight = weight;
            Rating = rating;
            Sku = sku;
            StockCount = stockCount;
            Price = price;
        }

        public int GetProductId()
        {
            return Convert.ToInt32(ProductId);
            //return ProductId;
        }
        public int GetCategoryId()
        {
            return Convert.ToInt32(CategoryId);
            //return CategoryId;
        }
        public int GetSaleId()
        {
            return Convert.ToInt32(SaleId);
            //return SaleId;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetDescription()
        {
            return Description;
        }
        public string GetManInfo()
        {
            return ManInfo;
        }
        public string GetDimensions()
        {
            return Dimensions;
        }
        public double GetWeight()
        {
            return Convert.ToDouble(Weight);
            //return Weight;
        }
        public double GetRating()
        {
            return Convert.ToDouble(Rating);
            //return Rating;
        }
        public string GetSku()
        {
            return Sku;
        }
        public int GetStockCount()
        {
            return Convert.ToInt32(StockCount);
            //return StockCount;
        }

        public double GetPrice() {
            return Convert.ToDouble(Price);
        }

    }
}
