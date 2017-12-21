using MallSdk.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    [MallRoute("/OnLine/v1.2/CreateOrder")]
    public class CreateOrderRequest : BaseRequest, IMallRequest<CreateOrderResponse>
    {
        /// <summary>
        /// 订单号码
        /// </summary>
        public string TPOrderNo { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        public int GoodsType { get; set; }

        ///// <summary>
        ///// 商户ID
        ///// </summary>
        //public string BussinessID { get; set; }
        /// <summary>
        /// 会员ID
        /// </summary>
        public string LeaguerID { get; set; }

        /// <summary>
        /// 顾客姓名
        /// </summary>
        public string GuestName { get; set; }

        /// <summary>
        /// 顾客手机
        /// </summary>
        public string GuestMobile { get; set; }
        /// <summary>
        /// 订单金额
        /// </summary>
        public decimal OrderMoney { get; set; }

        /// <summary>
        ///优惠券号码
        /// </summary>
        public string CouponNumber { get; set; }

        public List<OrderItemResponse> OrderItem { get; set; }
        /// <summary>
        /// 送货地址
        /// </summary>
        public string SendAddress { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Summary { get; set; }
    }

    public class OrderItemResponse
    {
        ///// <summary>
        ///// OrderItemID
        ///// </summary>
        //public string ItemID { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public string GoodsID { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsName { get; set; }
        /// <summary>
        /// 商品售价(结算价格)
        /// </summary>
        public decimal GoodsPrice { get; set; }
        ///// <summary>
        ///// 渠道商品定价ID
        ///// </summary>
        //public string GoodsPriceID { get; set; }

        /// <summary>
        ///购买数量
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Json扩展信息
        /// </summary>
        public string ExtendedContent { get; set; }

        ///// <summary>
        /////是否自取
        ///// </summary>
        //public bool IsComeTake { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Summary { get; set; }

    }



    /// <summary>
    /// 订单创建传送
    /// </summary>
    [MallRoute("/OnLine/v1.2/DTOLeaguerApplyCreateOrder")]
    public class DTOLeaguerApplyCreateOrderVer1_2 : BaseRequest, IMallRequest<DTOLeaguerApplyCreateOrderResponseVer1_2>
    {
        /// <summary>
        /// 订单号码
        /// </summary>
        public string TPOrderNo { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        public decimal OrderMoney { get; set; }

        //public DTOOrderItem OrderItem { get; set; }
        /// <summary>
        /// 商品ID
        /// </summary>
        public string GoodsID { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsName { get; set; }
        /// <summary>
        /// 商品售价(结算价格)
        /// </summary>
        public decimal GoodsPrice { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string UserPass { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public string Birthday { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 身份证
        /// </summary>
        public string IDCard { get; set; }
        /// <summary>
        /// 性别(-1未知,0女,1男)
        /// </summary>
        public int? Sex { get; set; }
        /// <summary>
        /// 子女姓名
        /// </summary>
        public string ChildName { get; set; }
        /// <summary>
        /// 子女生日
        /// </summary>
        public string ChildBirthday { get; set; }
        /// <summary>
        /// 子女性别(-1未知,0女,1男)
        /// </summary>
        public int? ChildSex { get; set; }
        /// <summary>
        /// 子女2姓名
        /// </summary>
        public string Child2Name { get; set; }
        /// <summary>
        /// 子女2生日
        /// </summary>
        public string Child2Birthday { get; set; }
        /// <summary>
        /// 子女2性别(-1未知,0女,1男)
        /// </summary>
        public int? Child2Sex { get; set; }
        /// <summary>
        /// 即时通讯号码
        /// </summary>
        public string IMNO { get; set; }
        /// <summary>
        /// QQ
        /// </summary>
        public string QQ { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Summary { get; set; }
    }



    public class DTOLeaguerApplyCreateOrderResponseVer1_2 : MallResponse
    {
        public string OrderID
        {
            get;
            set;
        }

        /// <summary>
        /// 总金额
        /// </summary>
        public decimal TotleMoney
        {
            get;
            set;
        }
        /// <summary>
        /// 折扣金额
        /// </summary>
        public virtual decimal Discount
        {
            get;
            set;
        }
    }

    /// <summary>
    /// 订单创建传送1.1版
    /// </summary>   
    [MallRoute("/OnLine/v1.2/DTOLeaguerApplyCompleteOrder")]
    public class DTOLeaguerApplyCompleteOrderVer1_2 : BaseRequest, IMallRequest<DTOLeaguerInfoVer1_2>
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        public string OrderID { get; set; }
        /// <summary>
        /// 支付名称
        /// </summary>
        public int PayName { get; set; }
        /// <summary>
        /// 收款账号
        /// </summary>
        public string AccountNumber { get; set; }
        /// <summary>
        /// 线上订单
        /// </summary>
        public string OnLineOrder { get; set; }
    }
    /// <summary>
    /// 单个会员详细资料
    /// </summary>
    public class DTOLeaguerInfoVer1_2 : MallResponse
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        public string LeaguerID { get; set; }
        /// <summary>
        /// 是否取卡
        /// </summary>
        public bool IsTake { get; set; }
        /// <summary>
        /// 会员号
        /// </summary>
        public string LeaguerCode { get; set; }
        /// <summary>
        /// 会员等级ID
        /// </summary>
        public string LeaguerLevelID { get; set; }

        /// <summary>
        /// 会员等级名称
        /// </summary>
        public string LeaguerLevelName { get; set; }

        /// <summary>
        /// 会员状态ID
        /// </summary>
        public int LeaguerStatus { get; set; }

        /// <summary>
        /// 会员状态描述
        /// </summary>
        public string LeaguerStatusDesc { get; set; }



        /// <summary>
        /// 真实姓名
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTime? VerifyTime { get; set; }

        ///// <summary>
        ///// 开卡商户ID
        ///// </summary>
        //public string OpenBusiness { get; set; }

        /// <summary>
        /// 开卡商户名称
        /// </summary>
        public string OpenBusinessName { get; set; }

        /// <summary>
        /// 性别,1男0女
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address
        {
            get;
            set;
        }

        /// <summary>
        /// 生日
        /// </summary>

        public DateTime? Birthday
        {
            get;
            set;
        }

        /// <summary>
        /// 邮箱
        /// </summary>

        public string Email
        {
            get;
            set;
        }


        /// <summary>
        /// 身份证
        /// </summary>

        public string IDCard
        {
            get;
            set;
        }

        /// <summary>
        /// 子女姓名
        /// </summary>

        public string ChildName
        {
            get;
            set;
        }

        /// <summary>
        /// 子女生日
        /// </summary>

        public DateTime? ChildBirthday
        {
            get;
            set;
        }

        /// <summary>
        /// 子女性别
        /// </summary>

        public int ChildSex
        {
            get;
            set;
        }

        /// <summary>
        /// 子女2姓名
        /// </summary>

        public string Child2Name
        {
            get;
            set;
        }

        /// <summary>
        /// 子女2生日
        /// </summary>

        public DateTime? Child2Birthday
        {
            get;
            set;
        }

        /// <summary>
        /// 子女2性别
        /// </summary>

        public int Child2Sex
        {
            get;
            set;
        }

        /// <summary>
        /// 电话
        /// </summary>

        public string Phone
        {
            get;
            set;
        }

        /// <summary>
        /// 注册时间
        /// </summary>

        public DateTime RegTime
        {
            get;
            set;
        }

        /// <summary>
        /// 即时通讯号码
        /// </summary>

        public string IMNO
        {
            get;
            set;
        }

        /// <summary>
        /// QQ
        /// </summary>
        public string QQ
        {
            get;
            set;
        }

        /// <summary>
        /// 头像  
        /// </summary>
        public byte[] CA_Photo
        {
            get;
            set;
        }
    }
}
