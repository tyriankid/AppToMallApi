using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    /// <summary>
    /// 订单的可用支付方式
    /// </summary>
    public class GetOrderListResponse : MallResponse
    {
       public List<DTOOrderListDetails> List { get; set; }


    }
    public class PayTypeListItemResponse
    {
        /// <summary>
        /// 支付方式名称
        /// </summary>
        public string PayName { get; set; }

        /// <summary>
        /// 支付方式ID
        /// </summary>
        public string PayID { get; set; }

        /// <summary>
        /// 支付方式标识(注册列表中获取)
        /// </summary>
        public virtual int PayKind
        {
            get;
            set;
        }


    }

    public class DTOOrderListDetails
    {
        /// <summary>
        /// GUID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNumber { get; set; }
        /// <summary>
        /// 来自第三方的订单编号
        /// </summary>
        public string TPOrderCode
        {
            get;
            set;
        }
        /// <summary>
        /// 会员姓名+(卡号)
        /// </summary>
        public string LeaguerNameAndNumber { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        public decimal TotleMoney { get; set; }

        /// <summary>
        /// 是否结账
        /// </summary>
        public bool IsConsume { get; set; }

        /// <summary>
        /// 已支付金额
        /// </summary>
        public decimal PaidMoney { get; set; }

        /// <summary>
        /// 支付状态
        /// </summary>
        public int PayState { get; set; }

        /// <summary>
        /// 支付状态名称
        /// </summary>
        public string PayStateName { get; set; }
        /// <summary>
        /// 物流状态
        /// </summary>
        public int LogisticsState { get; set; }

        /// <summary>
        /// 物流状态名称
        /// </summary>
        public string LogisticsStateName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }


        /// <summary>
        /// 折扣金额
        /// </summary>
        public decimal Discount { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Summary { get; set; }
    }
}
