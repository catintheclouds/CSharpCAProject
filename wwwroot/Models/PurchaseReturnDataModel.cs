using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class PurchaseReturnDataModel
    {
        public string OrderDetailId { get; set; }
        public string OrderID { get; set; }
        public int ProductID { get; set; }
        public string ImageURL { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string DateOfPurchase { get; set; }
        public int OrderQty { get; set; }
        public string OrderStatus { get; set; }
        public string ActivationCode { get; set; }

        public List<string> ActivationCodes { get; set; }


    }
}
