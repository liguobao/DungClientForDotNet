using System;
using System.Collections.Generic;
using System.Text;

namespace DungClientForDotNet.Hepler
{
    public class HTTPHepler
    {
        public static string GetByURL(string url)
        {
            if (string.IsNullOrEmpty(url))
                throw new Exception($"GetByURL传入参数:{url} 有误。");
            System.Net.Http.HttpClient httpclient = new System.Net.Http.HttpClient();
            httpclient.Timeout = new TimeSpan(3000);
            return httpclient.GetStringAsync(url).Result;
        }
    }
}
