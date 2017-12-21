using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MallSdk.Request;

namespace MallSdk
{
    public class LeaguerValuesLogRequest : BaseRequest, IMallRequest<LeaguerValuesLogResponse>
    {
        /// <summary>
        /// 会员ID(必须)
        /// </summary>
        public string LeaguerID { get; set; }
        /// <summary>
        /// 储值类型(必须)
        /// </summary>
        public int ValueCode { get; set; }
        /// <summary>
        /// 储值类型ID(必须)
        /// </summary>
        public string ValueID { get; set; }
        /// <summary>
        /// 开始日期
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// 结束日期
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// 当前页数(必须)
        /// </summary>
        public int PageIndex { get; set; }
        /// <summary>
        /// 每页行数(必须)
        /// </summary>
        public int PageSize { get; set; }
    }
}
