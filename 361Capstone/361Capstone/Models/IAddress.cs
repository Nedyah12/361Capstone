namespace _361Capstone.Models
{
    public interface IAddress
    {
        public int GetAddressId();
        public int GetUserId();
        public string GetStreet();
        public string GetCity();
        public string GetState();
        public string GetZipCode();
        public string GetCountry();
    }
}
