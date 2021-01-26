using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaezer_POS_and_Inventory.Model
{
    interface IUnitMeasurement
    {
        int UnitID { get; set; }
        string UnitCode { get; set; }
        string Description { get; set; }
        int Qty { get; set; }
        bool DefaultUnit { get; set; }
    }
}
