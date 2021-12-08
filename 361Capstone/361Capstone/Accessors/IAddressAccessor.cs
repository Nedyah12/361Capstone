using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _361Capstone.Accessors {
    interface IAddressAccessor {
        void InsertAddress(int userId, string street, string city, string state, int zipCode, string country);
        List<string> GetAddressInfo(int userId);
        
    }
}
