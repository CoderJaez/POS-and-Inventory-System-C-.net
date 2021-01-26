using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaezer_POS_and_Inventory.Model
{
    interface IUser
    {
        int UserID { get; set; }
        string UserType { get; set; }
        string UserName { get; set; }

        string Fullname { get; set; }
        string Password { get; set; }
        bool Status { get; set; }

    }
}
