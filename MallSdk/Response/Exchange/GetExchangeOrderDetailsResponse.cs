using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class GetExchangeOrderDetailsResponse : MallResponse
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
        public decimal TotalPrice { get; set; }
        /// <summary>
        /// 原兑换总价（折前）
        /// </summary>
        public virtual decimal OriginalTotalPrice { get; set; }
        /// <summary>
        /// 总折扣
        /// </summary>
        public decimal TotalDiscount { get; set; }

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

        /// <summary>
        /// 收货人
        /// </summary>
        public string Consignee { get; set; }
        /// <summary>
        /// 收货人电话
        /// </summary>
        public string ConsigneePhone { get; set; }
        /// <summary>
        /// 收货地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 收货地址
        /// </summary>
        public string AddressInfo { get { return string.Format("{0} {1} {2}", Consignee, ConsigneePhone, Address); } }
        /// <summary>
        /// 物流备注
        /// </summary>
        public string LogisticsSummary { get; set; }
         /// <summary>
        /// 发货时间
        /// </summary>
        public DateTime? DeliverTime { get; set; }
         /// <summary>
        /// 收货时间
        /// </summary>
        public DateTime? ReceiveTime { get; set; }
        

        public bool IsCurrChannelOrder { get; set; }

        public List<ExchangeGoods> List { get; set; }

    }

    public class ExchangeGoods
    {

        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsName { get; set; }
        /// <summary>
        /// 商品原兑换价
        /// </summary>
        public decimal UnitPrice { get; set; }
        /// <summary>
        /// 折后兑换单价
        /// </summary>
        public decimal AfterDiscountUnitPrice { get; set; }
        /// <summary>
        /// 兑换数量
        /// </summary>
        public decimal GoodsCount { get; set; }
        /// <summary>
        /// 总折扣
        /// </summary>
        public decimal TotalDiscount { get; set; }
        /// <summary>
        /// 原兑换总价（折前）
        /// </summary>
        public decimal OriginalTotalPrice { get; set; }

        /// <summary>
        /// 总费用（原兑换总价（折前）-总折扣）
        /// </summary>
        public decimal TotalFee { get; set; }
    }
}
