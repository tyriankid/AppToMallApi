using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/GiftExchangeOnLine")]
    /// <summary>
    /// 礼品兑换
    /// </summary>
    public class GiftExchangeRequest : BaseRequest, IMallRequest<GiftExchangeResponse>
    {      
        /// <summary>
        /// 物流方式1：自取，2：邮寄
        /// </summary>
        public string LogisticsTypeID { get; set; }

        /// <summary>
        /// 收货地址ID(可空)
        /// </summary>
        public string ReceiveAddressID { get; set; }
        /// <summary>
        /// 支付方式 1=预存款 3=积分,401金币，402代币，403彩票
        /// </summary>
        public int PayValueType { get; set; }

        /// <summary>
        /// 会员ID
        /// </summary>
        public string LeaguerID { get; set; }

        /// <summary>
        /// 兑换的礼品
        /// </summary>
        public List<GiftItemRequest> GiftItem { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// 交易号(防重复)
        /// </summary>
        public string TransactionNo { get; set; }
    }
    /// <summary>
    /// 礼品信息
    /// </summary>
    public class GiftItemRequest
    {
        /// <summary>
        /// OnlineGiftID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public string GoodsID { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsName { get; set; }

        /// <summary>
        ///兑换数量
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Summary { get; set; }

    }
}
