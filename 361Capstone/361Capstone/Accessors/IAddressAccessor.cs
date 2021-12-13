using System.Collections.Generic;


namespace _361Capstone.Accessors {
    interface IAddressAccessor {
        void InsertAddress(int userId, string street, string city, string state, int zipCode, string country);
        List<string> GetAddressInfo(int userId);
        
    }
}
