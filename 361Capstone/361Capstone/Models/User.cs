using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Models
{
    public class User : IUser
    {
        private int UserId { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }

        private int CartId { get; set; }

        public User(int userId)
        {
            UserId = userId;
        }

        public User(int userId, string username, string password, int cartId)
        {
            UserId = userId;
            Username = username;
            Password = password;
            CartId = cartId;
        }

        public int GetUserId()
        {
            return UserId;
        }
        public string GetUsername()
        {
            return Username;
        }
        public string GetPassword()
        {
            return Password;
        }
        public int GetCartId()
        {
            return CartId;
        }
    }
}
