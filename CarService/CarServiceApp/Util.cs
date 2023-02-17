using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Http;

namespace CarServiceApp
{
    public static class Util
    {
        private const String baseURL = "http://localhost:55555/api/";

        public static void POST(string url, string jsonContent)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseURL + url);
            request.Method = "POST";

            UTF8Encoding encoding = new UTF8Encoding();
            Byte[] byteArray = encoding.GetBytes(jsonContent);

            request.ContentLength = byteArray.Length;
            request.ContentType = @"application/json";

            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }

            long length = 0;
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    length = response.ContentLength;
                }
            }
            catch
            {
                throw;
            }
        }


        public static void PUT(string url, string jsonContent)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseURL + url);
            request.Method = "PUT";

            UTF8Encoding encoding = new UTF8Encoding();
            Byte[] byteArray = encoding.GetBytes(jsonContent);

            request.ContentLength = byteArray.Length;
            request.ContentType = @"application/json";

            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }
            long length = 0;
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    length = response.ContentLength;
                }
            }
            catch
            {
                throw;
            }
        }

        public static void DELETE(string url, int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURL);

                var deleteTask = client.DeleteAsync(url + id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return;
                }
            }

            return;
        }
    }
}
