using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Project
{
    public static class prices
    {
        public static int Goverment = 300;
        public static int Commerce = 500;
        public static int govermentPrice
        {
            get { return Goverment; }
            set { Goverment = value; }
        }
        public static int commercialPrice
        {
            get { return Commerce; }
            set { Commerce = value; }
        }

    }
}
