using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaezer_POS_and_Inventory.Model
{
    interface ISupplier
    {
        string BusinessName { get; set; }
        string SupplierName { get; set; }
        string Contact { get; set; }
        string StreetAddress { get; set; }
        string Barangay { get; set; }
        string CityMun { get; set; }
        string Province { get; set; }
        string Adress { get; }
    }
}
