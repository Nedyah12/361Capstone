﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _361Capstone.Accessors {
    interface ICartProductAccessor {
        bool InsertCartProduct(int cartId, int productId, int quantity);
        void RemoveCartProduct(int cartId, int productId);
        void ChangeCartProductQuantity(int cartId, int productId, int newQuantity);

    }
}
