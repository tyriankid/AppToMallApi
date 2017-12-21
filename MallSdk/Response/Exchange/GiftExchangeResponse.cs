using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class GiftExchangeResponse : MallResponse
    {
        /// <summary>
        /// 兑换单号
        /// </summary>
        public string ExchangeNum
        {
            get;
            set;
        }
        /// <summary>
        /// 支付方式
        /// </summary>
        public int ExchangeValueType
        {
            get;
            set;
        }
        /// <summary>
        /// 支付方式名称
        /// </summary>
        public string ExchangeValueTypeName
        {
            get;
            set;
        }
        /// <summary>
        /// 支付方式对应的余额
        /// </summary>
        public decimal Balance { get; set; }


        /// <summary>
        /// 交易号(防重复)
        /// </summary>
        public string TransactionNo { get; set; }
    }
}
