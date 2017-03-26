using System;
using System.Collections.Generic;
using System.Text;

namespace DungClientForDotNet.Model
{
    public class ProxyIPInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string proxyIp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int port { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ipValue { get; set; }
        /// <summary>
        /// 阿尔巴尼亚
        /// </summary>
        public string country { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string area { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string region { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string city { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string isp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string countryId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string areaId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string regionId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cityId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ispId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int transperent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int speed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int connectionScore { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int availbelScore { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int connectionScoreDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int availbelScoreDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int createtime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string lostheader { get; set; }
    }

    public class AvInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public List<ProxyIPInfo> data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int num { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sign { get; set; }
    }

    public class AVAPIResult
    {
        /// <summary>
        /// 
        /// </summary>
        public AvInfo data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string status { get; set; }
    }

}
