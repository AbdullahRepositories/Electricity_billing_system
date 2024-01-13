using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IP_Project
{
    public static  class Operations
    {
      static   WebRequest request;
        //static  string Convert_Retrieve(string postData)
        //{
        //    ASCIIEncoding enc = new ASCIIEncoding();
        //    byte[] data = enc.GetBytes(postData);
        //    Stream stream = request.GetRequestStream();
        //    stream.Write(data, 0, data.Length);

        //    WebResponse response = request.GetResponse();
        //    Stream stream2 = response.GetResponseStream();
        //    StreamReader sr = new StreamReader(stream2);

        //    string result = sr.ReadToEnd();
        //    return result;
        //}
        public  static string  Get(string Url,string postData){

             request = WebRequest.Create(Url);
            request.Method = "POST";// the method to send data
            request.ContentType = "application/x-www-form-urlencoded";
            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] data = enc.GetBytes(postData);
            Stream stream = request.GetRequestStream();
            stream.Write(data, 0, data.Length);

            WebResponse response = request.GetResponse();
            Stream stream2 = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream2);

            string result = sr.ReadToEnd();

            return result;
        }
       
       

      //  public static string Put(string Url,string postData) {

      //      request = WebRequest.Create(Url);
      //      request.Method = "POST";// the method to send data
      //      request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)

      //      //string postData = "id=" + column;

      //      string result = Convert_Retrieve(postData);
      //      return result;
      //  }
      ////public static string Put(string Url, string column1, string column2, string column3, string column4, string column5, string column6)
      ////  {
      ////      request = WebRequest.Create(Url);
      ////      request.Method = "POST";// the method to send data
      ////      request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)


      ////      string postData = "name=" + column1 + "&email=" + column2 + "&phone=" + column3 + "&password=" + column4 + "&address=" + column5 + "&id=" + column6;

      ////      string result = Convert_Retrieve(postData);
      ////      return result;

      ////  }
      //  public static string Delete(string Url,string id) {

      //      request = WebRequest.Create(Url);
      //      request.Method = "POST";// the method to send data
      //      request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)

      //      string postData = "id=" + id;
      //      string result = Convert_Retrieve(postData);
      //      return result;
      //  }

      //  public static string Insert(string Url , string column1,string column2)
      //  {
      //      request = WebRequest.Create(Url);
      //      request.Method = "POST";// the method to send data
      //      request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)

      //      string postData = "id=" + column1 + "&complain=" + column2;
      //      string result = Convert_Retrieve(postData);
      //      return result;

      //  }

      //  public static string Insert(string Url, string column1, string column2, string column3, string column4, string column5, string column6, string column7)
      //  {
      //       request = WebRequest.Create(Url);
      //      request.Method = "POST";// the method to send data
      //      request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)

      //      string postData = "name=" + column1 + "&email=" + column2 + "&phone=" + column3 + "&password=" + column4 + "&address=" + column5 + "&types=" + column6 + "&meterType=" + column7;

      //      string result = Convert_Retrieve(postData);
      //      return result;
      //  }
      //  public static string Insert(string Url, string column1, string column2, string column3, string column4, string column5, string column6)
      //  {
      //      request = WebRequest.Create(Url);
      //      request.Method = "POST";// the method to send data
      //      request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)

      //      string postData = "name=" + column1 + "&email=" + column2 + "&phone=" + column3 + "&password=" + column4 + "&address=" + column5 + "&types=" + column6 ;

      //      string result = Convert_Retrieve(postData);
      //      return result;
      //  }
      //  public static string Insert(string Url, string column1, float column2, float column3, string column4, float column5)
      //  {
      //      request = WebRequest.Create(Url);
      //      request.Method = "POST";// the method to send data
      //      request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)
      //      string postData = "meter_id=" + column1 + "&total_unit=" + column2 + "&total_bill=" + column3 + "&unit_price=" + column4 + "&previous_reading=" +column5;


      //      string result = Convert_Retrieve(postData);
      //      return result;
      //  }
    }
}
