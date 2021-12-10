using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Models
{
    public class Category : ICategory
    {
        private int CategoryId { get; set; }
        private string Title { get; set; }
        private string SaleId { get; set; }

        public Category(int categoryId, string title)
        {
            CategoryId = categoryId;
            Title = title;
        }

        public Category(int categoryId, string title, string saleId)
        {
            CategoryId = categoryId;
            Title = title;
            SaleId = saleId;
        }

        public int GetCategoryId()
        {
            return CategoryId;
        }

        public string GetTitle() {
            return Title;
        }
        public string GetSaleId() {
            return SaleId;
        }

    }
}
