using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Models
{
    public class List
    {
        private long IdList { get; set; }
        private string Title { get; set; }
        private List<Products> products { get; set; }
    }
}
