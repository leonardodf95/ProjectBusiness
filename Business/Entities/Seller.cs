using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Entities
{
    class Seller
    {
        public string SellerName { get; set; }
        public int CodeSeller { get; set; }

        public Seller()
        {
        }

        public Seller(string sellerName, int codeSeller)
        {
            SellerName = sellerName;
            CodeSeller = codeSeller;
        }


    }
}
