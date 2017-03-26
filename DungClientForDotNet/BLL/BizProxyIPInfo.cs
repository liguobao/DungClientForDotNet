using DungClientForDotNet.Hepler;
using DungClientForDotNet.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungClientForDotNet.BLL
{
    public class BizProxyIPInfo
    {
        public string CheckURL { get; set; }

        public string CheckDomain { get; private set; }

        public int APIQueryPageCount { get; set; }


        public void LoadProxyIPInfo()
        {
            var avAPIData = WebAPIHelper.GetAPIResult<AVAPIResult>(ConfigInfo.AVAPIURL
                + $"?usedSign=&checkUrl={CheckURL}&domain={CheckDomain}&num={APIQueryPageCount}");
            if(avAPIData!=null && avAPIData.data!=null && avAPIData.data.data != null)
            {
                Console.WriteLine(""+avAPIData.data.data.Count);
            }
        }





        #region public prop

        /// <summary>
        /// 
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ProxyIP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Port { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int IPValue { get; set; }
        /// <summary>
        /// 阿尔巴尼亚
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Area { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Region { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ISP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CountryID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AreaID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string RegionID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CityID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ISPID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Transperent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Speed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ConnectionScore { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int AvailbelScore { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ConnectionScoreDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int AvailbelScoreDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Createtime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Lostheader { get; set; }
        #endregion



    }
}
