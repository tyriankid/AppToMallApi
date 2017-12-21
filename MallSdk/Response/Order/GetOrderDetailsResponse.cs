using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class GetOrderDetailsResponse : MallResponse
    {
        /// <summary>
        /// GUID
        /// </summary>
        public string ID { get; set; }
        public string TPOrderCode { get; set; }
        /// <summary>
        /// 是否当前渠道订单
        /// </summary>
        public bool IsCurrChannelOrder { get; set; }
        /// <summary>
        /// 商品数量
        /// </summary>
        public decimal GoodsAmount { get; set; }
        /// <summary>
        /// 订单商品（逗号分割）
        /// </summary>
        public string GoodsNames { get; set; }
        /// <summary>
        /// 订单商品类型（逗号分割）
        /// </summary>
        public string GoodsTypes { get; set; }
        /// <summary>
        /// 订单支付方式（逗号分割）
        /// </summary>
        public string PayTypeNames { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// 会员姓名+(卡号)
        /// </summary>
        public string LeaguerNameAndNumber { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        public decimal TotleMoney { get; set; }
        /// <summary>
        /// 折扣金额
        /// </summary>
        public decimal Discount { get; set; }
        /// <summary>
        /// 是否结账
        /// </summary>
        public bool IsConsume { get; set; }

        /// <summary>
        /// 已支付金额
        /// </summary>
        public decimal PaidMoney { get; set; }

        /// <summary>
        /// 账期
        /// </summary>
        public string PeriodName { get; set; }

        ///// <summary>
        ///// 订单类型
        ///// </summary>
        //public string OrderType { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        public string EmpNameAndAccount { get; set; }

        /// <summary>
        /// 操作终端
        /// </summary>
        public string TerminalName { get; set; }

        ///// <summary>
        ///// 状态
        ///// </summary>
        //public string State { get; set; }

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



    }
}
