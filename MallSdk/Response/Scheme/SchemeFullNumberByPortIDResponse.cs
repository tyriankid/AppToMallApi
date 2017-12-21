using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class SchemeFullNumberByPortIDResponse : MallResponse
    {
        public string ID { get; set; }

        /// <summary>
        /// 方案名称
        /// </summary>
        public string SchemeName { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string MachineName { get; set; }
        /// <summary>
        /// 生效时间
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 失效时间
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        ///     是否启用
        /// </summary>
        public bool IsEnable { get; set; }
        /// <summary>
        /// 是否在线
        /// </summary>
        public bool IsOnLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<FullNumberMapDetail> FullNumberMaps { get; set; }
    }

    public class FullNumberMapDetail : MallResponse
    {
        public string ID { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public decimal MoneyAmount { get; set; }

        /// <summary>
        /// 次数
        /// </summary>
        public int Number { get; set; }
    }
}
