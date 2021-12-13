namespace _361Capstone.Models
{
    public class Address : IAddress
    {
        private int AddressId { get; set; }
        private int UserId { get; set; }
        private string Street { get; set; }
        private string City { get; set; }
        private string State { get; set; }
        private string ZipCode { get; set; }
        private string Country { get; set; }

        public Address(int addressId, int userId, string street, string city, string state, string zip, string country)
        {
            AddressId = addressId;
            UserId = userId;
            Street = street;
            City = city;
            State = state;
            ZipCode = zip;
            Country = country;
        }

        public int GetAddressId()
        {
            return AddressId;
        }
        public int GetUserId()
        {
            return UserId;
        }
        public string GetStreet()
        {
            return Street;
        }
        public string GetCity()
        {
            return City;
        }
        public string GetState()
        {
            return State;
        }
        public string GetZipCode()
        {
            return ZipCode;
        }
        public string GetCountry()
        {
            return Country;
        }
    }
}
