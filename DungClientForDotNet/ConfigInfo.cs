using System;
using System.Collections.Generic;
using System.Text;

namespace DungClientForDotNet
{
    public class ConfigInfo
    {
        public static string DungProxyCenterDomain = "http://115.159.40.202:8080/";

        /// <summary>
        ///  http://115.159.40.202:8080/proxyipcenter/av?usedSign=&checkUrl=http%3A%2F%2Ffree-proxy-list.net%2F&domain=free-proxy-list.net&num=10
        /// </summary>
        public static string AVAPIURL = DungProxyCenterDomain + "proxyipcenter/av?";

    }
}
