﻿using _361Capstone.Engine;
using _361Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Managers
{
    public class CheckoutManager : ICheckoutManager
    {
        CheckoutEngine Engine = new CheckoutEngine();

        public Address GetAddress(int userId) {
            List<String> addressInfo = Engine.GetAddressInfo(userId);
            Address address = new Address(0, 0,"", "","","","");
            try {
                address = new Address(Convert.ToInt32(addressInfo[0]), Convert.ToInt32(addressInfo[1]),
                                          addressInfo[2], addressInfo[3], addressInfo[4], addressInfo[5],
                                          addressInfo[6]);
            } catch(System.ArgumentOutOfRangeException e) {
                // Make user go to page to fill out info
                return address;
            }
            
            return address;
        }

        public PaymentInfo GetPaymentInfo(int userId) {
            List<String> paymentInfo = Engine.GetPaymentInfo(userId);
            PaymentInfo payment = new PaymentInfo(0, 0, "", 0, 0, 0);

            try {
                payment = new PaymentInfo(Convert.ToInt32(paymentInfo[0]),
                                                  Convert.ToInt32(paymentInfo[1]),
                                                  paymentInfo[2], Convert.ToInt32(paymentInfo[3]),
                                                  Convert.ToInt32(paymentInfo[4]),
                                                  Convert.ToInt32(paymentInfo[5]));
            } catch(System.ArgumentOutOfRangeException e) {
                return payment;
            }
            return payment;
        }  
        
        public void CompleteTransaction(int userId) {
            UserCartManager userCartManager = new UserCartManager();
            List<Product> products = userCartManager.GetUserCartProducts(userId);
            Engine.CompleteTransaction(userId, products);
        }
    }
}
