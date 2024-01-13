using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IP_Project
{
    public static class logger_proxy
    {
        public static void LogginDetails(string FileName,string operation)
        {
            File.AppendAllText("E:\\" + FileName,
               String.Format("\nThe person : {0} whose role is : {1} has logged at : {2} and did the operation : {3} \n",
               userInfo.userName,userInfo.userRole, DateTime.Now.ToString(),operation));
        }

    }

}