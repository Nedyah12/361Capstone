using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Models
{
    public interface ICategory
    {
        public int GetCategoryId();
        public string GetTitle();
        public string GetSaleId();
    }
}
