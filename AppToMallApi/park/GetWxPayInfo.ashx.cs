using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using WeiXin.Lib.Core.Helper.WXPay;
using WeiXin.Lib.Core.Models.UnifiedMessage;
using WeiXin.Lib.Core.Helper;

namespace FangApi.park
{
    /// <summary>
    /// GetWxPayInfo 的摘要说明
    /// </summary>
    public class GetWxPayInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string prepayid = string.Empty;

            if (context.Request["openid"] != null&&context.Request["price"]!=null&&context.Request["title"]!=null)
            {
                string orderNo = DateTime.Now.ToString("yyyyMMddhhmmssfff"); //文档中的out_trade_no
                string description = context.Request["title"].ToString(); //商品描述
                string totalFee = (Convert.ToDecimal(context.Request["price"].ToString())*100).ToString("0");//订单金额（单位：分）
                string createIp = "127.0.0.1";
                string notifyUrl = "https://api.uifang.com/payway.ashx"; //通知url
                // string openId = WeiXinHelper.GetUserOpenId(code);//通过网页授权code获取用户openid（或者之前有存储用户的openid 也可以直接拿来用）
                createIp = "127.0.0.1";
                //   code = "031937cca83477222807bef025b247L";
                string openId = "";

                //openId = context.Request["openid"].ToString();
                openId = context.Request["openid"].ToString();
                // string openId = WeiXinHelper.GetUserOpenId(code);
                //prepayid 只有第一次支付时生成，如果需要再次支付，必须拿之前生成的prepayid。
                //也就是说一个orderNo 只能对应一个prepayid


                //创建Model
                UnifiedWxPayModel model = UnifiedWxPayModel.CreateUnifiedModel("wx65cd51f5b9c0cac6", "1491450372", "asd57491714asd57491714asd5749171");

                //预支付
                UnifiedPrePayMessage result = WeiXinHelper.UnifiedPrePay(model.CreatePrePayPackage(description, orderNo, totalFee, createIp, notifyUrl, openId));

                if (result == null
                        || !result.ReturnSuccess
                        || !result.ResultSuccess
                        || string.IsNullOrEmpty(result.Prepay_Id))
                {

                    prepayid = result.Return_Msg.ToString();
                    //  viewdata.state = false;
                    //    viewdata.error = openId + "," + code + "," + "," + result.Return_Msg.ToString();


                }
                else
                {

                    //预支付订单
                    prepayid = result.Prepay_Id;
                    PayModel payModel = new PayModel()
                    {
                        AppId = model.AppId,
                        Package = string.Format("prepay_id={0}", prepayid),
                        Timestamp = ((DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000).ToString(),
                        Noncestr = CommonUtil.CreateNoncestr(),
                    };
                    Dictionary<string, string> nativeObj = new Dictionary<string, string>();
                    nativeObj.Add("appId", payModel.AppId);
                    nativeObj.Add("package", payModel.Package);
                    nativeObj.Add("timeStamp", payModel.Timestamp);
                    nativeObj.Add("nonceStr", payModel.Noncestr);
                    nativeObj.Add("signType", payModel.SignType);
                    payModel.PaySign = model.GetCftPackage(nativeObj); //生成JSAPI 支付签名
                    payModel.OrderId = orderNo;
                    prepayid = JsonConvert.SerializeObject(payModel);
                }
            }
            context.Response.ContentType = "text/plain";
            context.Response.Write(prepayid);
        }
        public class PayModel
        {
            public string AppId { get; set; }
            public string OrderId { get; set; }
            public string Package { get; set; }
            public string Timestamp { get; set; }
            public string Noncestr { get; set; }
            public string PaySign { get; set; }
            public string SignType { get { return "MD5"; } }
        }
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}