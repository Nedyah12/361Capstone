using _361Capstone.Accessors;
using System;
using System.Collections.Generic;

namespace _361Capstone.Engine
{
    public class UserCartEngine : IUserCartEngine
    {
        CartProductAccessor Accessor = new CartProductAccessor();
        UserAccessor userAccessor = new UserAccessor();
        ProductAccessor productAccessor = new ProductAccessor();
        public List<List<String>> GetUserCartProductInfo(int userId) {
            List<List<String>> allProductInfo = new List<List<String>>();
            List<int> productIdQuantity = new List<int>();

            productIdQuantity = userAccessor.GetAllCartItems(userId);

            for(int i=0;i<productIdQuantity.Count-1;i++) {
                if(i % 2 == 0) {
                    List<String> tempList = new List<String>();
                    tempList = productAccessor.GetProductInfo(productIdQuantity[i]);
                    tempList.Add(productIdQuantity[i+1].ToString());
                    allProductInfo.Add(tempList);
                }
            }
            return allProductInfo;
        }
    }
}
