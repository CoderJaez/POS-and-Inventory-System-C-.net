using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaezer_POS_and_Inventory.Model
{
    interface IProductPrice
    {
        string Barcode { get; set; }
        string Variant { get; set; }
        decimal Price { get; set; }
        decimal SPrice { get; set; }
        bool IsSale { get; set; }
        string SDateFrm { get; set; }
        string SDateTo { get; set; }
        int PrQty { get; set; }
    }
}
