using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaezer_POS_and_Inventory.Model
{
     interface IPaymentTransaction
    {
        int PaymentID { get; set; }
        string InvoiceNo { get; set; }
        decimal SubTotal { get; set; }
        decimal Vat { get; set; }
        decimal Total { get; set; }
        decimal Discount { get; set;}
        decimal AmountDue { get; set; }
        string SDate { get; set; }
        decimal CashTendered { get; set; }
        decimal Change { get; set; }
        int UserID { get; set; }
    }
}
