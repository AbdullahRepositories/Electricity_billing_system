using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Project
{
    public static class URLs
    {

        public static readonly Dictionary<string, string> Url = new Dictionary<string, string>
        {
            { "complaintText","http://localhost:80/ebill2/complainform_.php"},
            { "customerComplaint","http://localhost:80/ebill2/consumercomplain_.php"},
            { "addUser","http://localhost:80/ebill2/Api/addUser_.php"},
            { "generateBill","http://localhost:80/ebill2/generate.php"},
            { "searchConsumer","http://localhost:80/ebill2/consumerlist__.php"},
            { "payBills","http://localhost:80/ebill2/payBill_.php"},
            { "viewBills","http://localhost:80/ebill2/viewbills_.php"},
            { "logIn","http://localhost:80/ebill2/login_.php"},
            { "searchBill","http://localhost:80/ebill2/searchBill_(2).php"},
            { "updateUser","http://localhost:80/ebill2/updateuser_.php" },
            { "deleteUser","http://localhost:80/ebill2/deleteuser_.php" },
            {"viewUser","http://localhost:80/ebill2/view_users_.php" }

        };

    }
}
