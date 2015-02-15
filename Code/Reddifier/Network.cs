using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;

namespace Reddifier
{
    public class Network
    {
        public static JToken downloadPosts(String subred)
        {
            String link = "http://" + "www.reddit.com/r/" + subred + "/new/.json?count=25";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(link);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                String json;
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    json = reader.ReadToEnd();
                    reader.Close();
                }
                response.Close();

                JObject jObject = JObject.Parse(json);
                return jObject["data"]["children"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return null;
        }
    }
}
