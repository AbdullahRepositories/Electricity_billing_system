using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Project.LogSingleton
{
    public interface ILog
    {
        void LogginDetails(string FileName, string operation);

    }
}
