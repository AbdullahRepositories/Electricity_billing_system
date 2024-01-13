using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Project.LogSingleton
{
    public sealed class Log : ILog
    {
        // private static Log instance = null;
        // private static readonly object obj = new object();
        private static readonly Lazy<Log> instance = new Lazy<Log>(() => new Log());

        private Log()
        {

        }
        public static Log GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        public void LogginDetails(string FileName, string operation)
        {
            File.AppendAllText("E:\\" + FileName,
               String.Format("\nThe person : {0} whose role is : {1} has logged at : {2} and did the operation : {3} \n",
               userInfo.userName, userInfo.userRole, DateTime.Now.ToString(), operation)); 
        }
    }
}
