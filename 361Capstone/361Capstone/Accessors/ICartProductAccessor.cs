using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Accessors {
    interface ICartProductAccessor {
        void InsertCartProduct(int cartId, int productId, int quantity);
        void RemoveCartProduct(int cartId, int productId);
        void ChangeCartProductQuantity(int cartId, int productId, int newQuantity);

    }
}
