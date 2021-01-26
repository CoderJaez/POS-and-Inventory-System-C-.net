using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaezer_POS_and_Inventory.Model
{
    interface ICategory
    {
        int CatID { get; set; }
        string Category { get; set; }
    }
}
