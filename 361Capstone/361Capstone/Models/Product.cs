using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Models
{
    public class Product : IProduct
    {
       
        private int ProductId { get; set; }
        private int CategoryId { get; set; }
        private int SaleId { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        private string ManInfo { get; set; }
        private string Dimensions { get; set; }
        private double Weight { get; set; }
        private double Rating { get; set; }
        private string Sku { get; set; }
        private int StockCount { get; set; }


        public Product(int productId, int categoryId, int saleId, string name, string desc, string manInfo, string dims, double weight, double rating, string sku, int stockCount)
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
        }

        public int GetProductId()
        {
            return ProductId;
        }
        public int GetCategoryId()
        {
            return CategoryId;
        }
        public int GetSaleId()
        {
            return SaleId;
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
            return Weight;
        }
        public double GetRating()
        {
            return Rating;
        }
        public string GetSku()
        {
            return Sku;
        }
        public int GetStockCount()
        {
            return StockCount;
        }

    }
}
