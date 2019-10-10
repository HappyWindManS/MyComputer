using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace WebSpider
{
    internal class JsonCnvData
    {
        private static string GetWebClient(string url)
        {
            string strHTML = "";
            WebClient myWebClient = new WebClient();
            Stream myStream = myWebClient.OpenRead(url);
            StreamReader sr = new StreamReader(myStream, System.Text.Encoding.GetEncoding("utf-8"));
            strHTML = sr.ReadToEnd();
            myStream.Close();
            return strHTML;
        }
    }
}
