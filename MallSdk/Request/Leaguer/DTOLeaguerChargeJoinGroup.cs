using System;
using System.Collections.Generic;
using MallSdk.Request;

namespace MallSdk
{
    /// <summary>
    /// 根据渠道id,渠道在线上获取所有的套餐列表（所有绑定商品已经定价）请求对象
    /// 返回 DTOGetLeaguerChargeJoinGroupResponse <typeparamref name="Mall.DTO.Online.DTOLeaguerChargeJoinGroupResponse"/>
    /// </summary>
    [MallRoute("/OnLine/v1.2/LeaguerChargeJoinGroup")]
    public class DTOLeaguerChargeJoinGroupRequestVer1_2 : BaseRequest, IMallRequest<DTOLeaguerChargeJoinGroupResponseVer1_2>
    {
    }

    /// <summary>
    /// 根据渠道id,渠道在线上获取所有的套餐列表（所有绑定商品已经定价）Response
    /// </summary>
    public class DTOLeaguerChargeJoinGroupResponseVer1_2 : MallResponse
    {
        public DTOLeaguerChargeJoinGroupResponseVer1_2()
        {
            this.List = new List<DTOLeaguerChargeJoinGroupItemResponseVer1_2>();
        }
        public List<DTOLeaguerChargeJoinGroupItemResponseVer1_2> List { get; set; }
    }

    /// <summary>
    /// 根据渠道id,渠道在线上获取所有的套餐列表（所有绑定商品已经定价）返回对象 ResponseItem
    /// </summary>
    public class DTOLeaguerChargeJoinGroupItemResponseVer1_2
    {
        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public string GoodsID { get; set; }
        /// <summary>
        /// 商品售价(结算价格)
        /// </summary>
        public decimal GoodsPrice { get; set; }
        /// <summary>
        /// 促销价
        /// </summary>
        public decimal PromoPrice { get; set; }
        /// <summary>
        /// 促销原因
        /// </summary>
        public string PromoReason { get; set; }
        /// <summary>
        /// 商品类型
        /// </summary>
        public int GoodsType { get; set; }
        /// <summary>
        /// 扩展商品
        /// </summary>
        public string ExtendGoods { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        public string GoodsCode
        {
            get;
            set;
        }
        /// <summary>
        /// 商品描述
        /// </summary>

        public string Summery { get; set; }

        public List<DTOChildGoodsVer1_2> ChildsGoods { get; set; }
    }


    public class DTOChildGoodsVer1_2
    {
        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public string GoodsID { get; set; }
        /// <summary>
        /// 商品售价(结算价格)
        /// </summary>
        public decimal GoodsPrice { get; set; }

        /// <summary>
        /// 促销价
        /// </summary>
        public decimal PromoPrice { get; set; }
        /// <summary>
        /// 促销原因
        /// </summary>
        public string PromoReason { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        public int GoodsType { get; set; }
        /// <summary>
        /// 扩展商品
        /// </summary>
        public string ExtendGoods { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        public string GoodsCode
        {
            get;
            set;
        }
        /// <summary>
        /// 商品描述
        /// </summary>
        public string Summery { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal Amount { get; set; }
    }
}
