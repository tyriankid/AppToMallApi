using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class GetShareLogsOnLineResponse : MallResponse
    {
        public List<ShareLogsDetailsOnLineResponse> List { get; set; }
    }

    public class ShareLogsDetailsOnLineResponse
    {
        /// <summary>
        /// GUID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// 分享类别
        /// </summary>
        public int ShareType { get; set; }
        /// <summary>
        /// 分享类别名称
        /// </summary>
        public string ShareTypeName { get; set; }

        /// <summary>
        /// 会员名
        /// </summary>
        public string LeaguerName
        {
            get;
            set;
        }
        /// <summary>
        /// 奖项数量
        /// </summary>
        public decimal Number { get; set; }
        /// <summary>
        /// 中奖项名
        /// </summary>
        public string GoodsTypeName { get; set; }
        /// <summary>
        /// 奖品名
        /// </summary>
        public string GoodsName { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Summary { get; set; }
        
        /// <summary>
        /// 抽奖时间
        /// </summary>
        public DateTime LogTime
        {
            get;
            set;
        }
    }
}
