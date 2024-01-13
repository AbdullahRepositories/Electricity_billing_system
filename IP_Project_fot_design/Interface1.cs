using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Project
{
    interface IOperation
    {
        void Get();
        void GetSpecific();
        void Put();
        void Post();
        void Delete();
    }
}
