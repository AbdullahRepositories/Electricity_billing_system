using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Project
{
    public static class userInfo
    {

       //static public proxy_login proxy ;
        public static string  userId { get; set; }
        public static string userName { get; set; }
        public static string userPassword { get; set; }
        public static string userEmail { get; set; }
        public static string userPhone { get; set; }
        public static string userAddress { get; set; }
        public static string userRole { get; set; }
    }

    //public class userInfoSingleton{

    //        public  string userId { get; set; }
    //        public string userName { get; set; }
    //        public  string userPassword { get; set; }
    //        public string userEmail{ get; set; }
    //        public  string userPhone{ get; set; }
    //        public  string userAddress{ get; set; }  
    //        public  string userRole{ get; set; }

    //    private static userInfoSingleton userInfo = new userInfoSingleton();
    //    private userInfoSingleton() { }
    //    public static userInfoSingleton GetuserInfo { get { return userInfo; } }
    //}
}
