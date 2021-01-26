using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaezer_POS_and_Inventory.Model
{
    interface IProductCart:IProduct,IProductPrice,IUnitMeasurement
    {
        int CartID { get; set; }
        string Invoice { get; set; }
        decimal Discount { get; set; }
        decimal Total { get; set; }
        string SDate { get; set; }
        int UserID { get; set; }
        string User { get; set; }
    }
}
