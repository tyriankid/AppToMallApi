using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class GetGiftLogisticsListResponse : MallResponse
    {
        public List<GiftLogisticsDetailsResponse> List { get; set; }
    }

    public class GiftLogisticsDetailsResponse 
    {

        public string Id { get; set; }
        /// <summary>
        /// 物流方式类别
        /// </summary>
        public int LogisticsType
        {
            get;
            set;
        }
        /// <summary>
        /// 物流方式名称
        /// </summary>
        public string LogisticsTypeName
        {
            get;
            set;
        }
        
        /// <summary>
        /// 运费耗积分
        /// </summary>
        public decimal FreightForHEAPCENT
        {
            get;
            set;
        }
        /// <summary>
        /// 运费耗彩票
        /// </summary>
        public decimal FreightForTICKET
        {
            get;
            set;
        }
        /// <summary>
        /// 运费耗币
        /// </summary>
        public decimal FreightForCOIN
        {
            get;
            set;
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Summary { get; set; }
    }
}
