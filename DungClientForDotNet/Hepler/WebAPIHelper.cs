using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;

namespace DungClientForDotNet.Hepler
{
    public class WebAPIHelper
    {
        /// <summary>
        /// 通过接口获取数据
        /// </summary>
        /// <typeparam name="T">返回数据类型</typeparam>
        /// <param name="apiURL">接口AIP地址</param>
        /// <returns>返回数据类型</returns>
        public static T GetAPIResult<T>(string apiURL)
        {
            var resultHTML = HTTPHepler.GetByURL(apiURL);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(apiURL);
        }
    }
}
