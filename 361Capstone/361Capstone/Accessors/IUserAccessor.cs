using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Accessors {
    interface IUserAccessor {
        int insertUser(string email, string password);
        void changePassword(int userId, string newPassword);
        bool validateUserInfo(string email, string password);
        string getUsername(int userId);
        string getPassword(int userId);
        int getUserIdFromUsername(string username);
        List<int> GetAllCartItems(int userId);
    }
}
