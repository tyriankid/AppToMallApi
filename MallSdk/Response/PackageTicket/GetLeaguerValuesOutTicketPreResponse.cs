using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class GetLeaguerValuesOutTicketPreResponse : MallResponse
    {
        /// <summary>
        /// 余额明细记录
        /// </summary>
        public List<LeaguerValuesItemResponse> rows { get; set; }
        /// <summary>
        /// 套票余额
        /// </summary>
        public int? PackageTicketValues { get; set; }
    }
    public class LeaguerValuesItemResponse
    {
        /// <summary>
        /// 商户名称(积分和预存款则显示为空【总部】)
        /// </summary>
        public string BusinessName { get; set; }

        /// <summary>
        /// 储值类型ID
        /// </summary>
        public string ValueID { get; set; }
        /// <summary>
        /// 储值类型
        /// </summary>
        public int ValueCode { get; set; }

        /// <summary>
        /// 储值类型名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string StatusDesc { get; set; }
        public int Status { get; set; }
    }
}
