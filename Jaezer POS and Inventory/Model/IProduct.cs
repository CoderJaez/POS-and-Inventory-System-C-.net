using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaezer_POS_and_Inventory.Model
{
    interface IProduct
    {
        int ProductID { get; set; }
        string ProductName { get; set; }
        int ReOrder { get; set; }
        bool HasExpiry { get; set; }
        int dayExpiry { get; set; }
        int Onhand { get; set; }
    }
}
