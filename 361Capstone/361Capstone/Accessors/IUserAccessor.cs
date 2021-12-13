using System.Collections.Generic;

namespace _361Capstone.Accessors {
    interface IUserAccessor {
        int InsertUser(string email, string password);
        void ChangePassword(int userId, string newPassword);
        bool ValidateUserInfo(string email, string password);
        string GetUsername(int userId);
        string GetPassword(int userId);
        int GetUserIdFromUsername(string username);
        List<int> GetAllCartItems(int userId);
    }
}
