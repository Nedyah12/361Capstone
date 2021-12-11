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
        private Cart Cart { get; set; }
        private Address Address { get; set; }
        private PaymentInfo PaymentInfo { get; set; }

        public User(int userId)
        {
            UserId = userId;
        }

        public User(int userId, string username, string password)
        {
            UserId = userId;
            Username = username;
            Password = password;
        }

        public User(int userId, string username, string password, Cart cart)
        {
            UserId = userId;
            Username = username;
            Password = password;
            Cart = cart;
        }

        public User(int userId, string username, string password, Address address)
        {
            UserId = userId;
            Username = username;
            Password = password;
            Address = address;
        }

        public User(int userId, string username, string password, Cart cart, Address address, PaymentInfo payment)
        {
            UserId = userId;
            Username = username;
            Password = password;
            Address = address;
            PaymentInfo = payment;
            Cart = cart;
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
        public Cart GetCart()
        {
            return Cart;
        }
        public Address GetAddress()
        {
            return Address;
        }
        public PaymentInfo GetPaymentInfo()
        {
            return PaymentInfo;
        }
    }
}
