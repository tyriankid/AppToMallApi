using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class GetExchangeOrderListResponse : MallResponse
    {
        public List<ExchangeOrderListDetailsOnLineResponse> List { get; set; }
    }

    public class ExchangeOrderListDetailsOnLineResponse 
    {
        /// <summary>
        /// GUID
        /// </summary>
        public string ID { get; set; }
     
        /// <summary>
        /// 兑换单号
        /// </summary>
        public string ExchangeNum { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        public string ExchangeValueTypeName { get; set; }
        /// <summary>
        /// 物流方式
        /// </summary>
        public string LogisticsTypeName
        {
            get;
            set;
        }
        public int PayState
        {
            get;
            set;
        }
        public int LogisticsState
        {
            get;
            set;
        }
        /// <summary>
        /// 总费用
        /// </summary>
        public virtual decimal TotalPrice { get; set; } 
        /// <summary>
        /// 原兑换总价（折前）
        /// </summary>
        public virtual decimal OriginalTotalPrice { get; set; }
        /// <summary>
        /// 总折扣
        /// </summary>
        public virtual decimal TotalDiscount { get; set; }

        /// <summary>
        /// 其他费用
        /// </summary>
        public decimal OtherFee { get; set; }

        /// <summary>
        /// 支付状态名称
        /// </summary>
        public string PayStateName { get; set; }

        /// <summary>
        /// 物流状态名称
        /// </summary>
        public string LogisticsStateName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// 是否是退单
        /// </summary>
        public bool IsReturnLog { get; set; }
    }
}
