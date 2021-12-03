using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Models
{
    public class Product
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

        //private int IdProduct { get; set; }
        //private string description { get; set; }
        //private int IdList { get; set; }

        int GetProductId()
        {
            return ProductId;
        }
        int GetCategoryId()
        {
            return CategoryId;
        }
        int GetSaleId()
        {
            return SaleId;
        }
        string GetName()
        {
            return Name;
        }
        string GetDescription()
        {
            return Description;
        }
        string GetManInfo()
        {
            return ManInfo;
        }
        string GetDimensions()
        {
            return Dimensions;
        }
        double GetWeight()
        {
            return Weight;
        }
        double GetRating()
        {
            return Rating;
        }
        string GetSku()
        {
            return Sku;
        }
        int GetStockCount()
        {
            return StockCount;
        }

    }
}
