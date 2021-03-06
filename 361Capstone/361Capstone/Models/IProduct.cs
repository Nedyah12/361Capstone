namespace _361Capstone.Models
{
    public interface IProduct
    {
        int GetProductId();
        int GetCategoryId();
        int GetSaleId();
        string GetName();
        string GetDescription();
        string GetManInfo();
        string GetDimensions();
        double GetWeight();
        double GetRating();
        string GetSku();
        int GetStockCount();
    }
}