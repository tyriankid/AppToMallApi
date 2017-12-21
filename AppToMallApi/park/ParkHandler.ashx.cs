using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using UiFangSqlHelper;
using MallSdk;
using YCHLitJson;

namespace FangApi.park
{




    /// <summary>
    /// AddPrice 的摘要说明
    /// </summary>
    public class ParkHandler : IHttpHandler
    {
        private string appId = "QD001";
        private string secretkey = @"QD001";
        private string bussinessID = "D4D0B0A2-3523-49AC-8FBE-A71400D63DF4";
        private string leaguerID = "EFCB9871-394A-4287-BBB4-A7150095CCF5";
        private string Url = "http://119.23.124.64:9998";


        public void ProcessRequest(HttpContext context)
        {
            string text = context.Request["action"];
            string key;
            switch (key = text)
            {
                case "AddPrice":
                    AddPrice1(context);
                    break;
                case "GetCardTypies":
                    GetCardTypies(context);
                    break;
                case "LeaguerApplyCreateOrder":
                    LeaguerApplyCreateOrder(context);
                    break;
            }
        }

        /// <summary>
        /// 创建用户入会申请订单
        /// </summary>
        /// <param name="context"></param>
        private void LeaguerApplyCreateOrder(HttpContext context)
        {
            string goodsID = context.Request["goodsid"];
            string goodsName = context.Request["goodsname"];
            string goodsPrice = context.Request["goodsprice"];
            string phone = context.Request["phone"];
            string realName = context.Request["realName"];
            string address = context.Request["address"];
            string birthday = context.Request["birthday"];
            string email = context.Request["email"];
            string idCard = context.Request["idcard"];
            string sex = context.Request["sex"];
            string childName = context.Request["childname"];
            string childBirthday = context.Request["childbirthday"];
            string childSex = context.Request["childsex"];
            string openId = context.Request["openId"];
            string avatarUrl = context.Request["avatarUrl"];
            string wxNickName = context.Request["wxNickName"];
            //验证参数完整性


            if (string.IsNullOrEmpty(goodsID) || goodsID=="undefined" || string.IsNullOrEmpty(goodsName) || goodsName=="undefined" || string.IsNullOrEmpty(goodsPrice) || goodsPrice=="undefined"|| string.IsNullOrEmpty(phone)
                || string.IsNullOrEmpty(realName) || string.IsNullOrEmpty(birthday) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(idCard)
                || string.IsNullOrEmpty(sex))
            {
                context.Response.Write("{\"success\":\"false\",\"Status\":2}");
                return;
            }
            
            IMallClient _client = new DefaultMallClient(Url, secretkey, appId);
            DTOLeaguerApplyCreateOrderVer1_2 rCreateOrder = new DTOLeaguerApplyCreateOrderVer1_2
            {
                BussinessID = bussinessID,
                GoodsID = goodsID,
                GoodsPrice = decimal.Parse(goodsPrice),
                GoodsName = goodsName,
                Address = address,
                Birthday = birthday,
                Email = email,
                IDCard = idCard,
                ChildName = childName,
                ChildSex = Int32.Parse(childSex),
                ChildBirthday = childBirthday,
                TPOrderNo = Guid.NewGuid().ToString().Substring(0, 8),
                UserPass = "123456",
                Sex = Int32.Parse(sex),
                RealName =realName,
                Phone = phone,
                OrderMoney = decimal.Parse(goodsPrice),
                Summary = "openid:" + openId + " wxNickName:" + wxNickName //+ " avatarUrl:" + avatarUrl,
            };
            rCreateOrder.SetSign(rCreateOrder, appId, secretkey);
            var rCreateOrderresponse = _client.Execute(rCreateOrder);
            context.Response.Write(JsonMapper.ToJson(rCreateOrderresponse));


        }

        /// <summary>
        /// 获取会员套餐列表
        /// </summary>
        /// <param name="context"></param>
        private void GetCardTypies(HttpContext context)
        {
            DTOLeaguerChargeJoinGroupRequestVer1_2 request = new DTOLeaguerChargeJoinGroupRequestVer1_2
            {
                AppID = this.appId,
                BussinessID = this.bussinessID
            };
            //实例化mallsdk中的连接对象
            IMallClient _client = new DefaultMallClient(Url, secretkey, appId);
            //设置签名,时间戳等参数
            request.SetSign(request, appId, secretkey);
            //调用相应的接口并接收返回值
            var response = _client.Execute(request);
            string str = JsonMapper.ToJson(response);
            context.Response.Write(str);
        }


        private void AddPrice1(HttpContext context)
        {

            int i = 0;
            if (context.Request["cardid"] != null && context.Request["cardnum"] != null && context.Request["price"] != null)
            {
                int newbalance = 0;
                SqlParameter[] sp = new SqlParameter[] {
            new SqlParameter("@CardId", Int32.Parse(context.Request["cardid"].ToString())),
            new SqlParameter("@CardNum",context.Request["cardnum"].ToString()),
            new SqlParameter("@AddPrice",context.Request["price"].ToString()),
            new SqlParameter("@CreateTime",DateTime.Now),
            new SqlParameter("@UpdateUser",999999),
            new SqlParameter("@UpdateUserName","微信用户"),
            new SqlParameter("@RechargeFrom","乐园小程序"),
            new SqlParameter("@Mark","微信小程序充值")
            };
                string sql = @" insert Recharge(CardId,CardNum,AddPrice,CreateTime,UpdateUser,UpdateUserName,RechargeFrom,Mark)
                        values(@CardId,@CardNum,@AddPrice,@CreateTime,@UpdateUser,@UpdateUserName,@RechargeFrom,@Mark)";

                i = SqlHelper.ExecuteUpdate(SqlHelper.connstrpark, CommandType.Text, sql, sp);
                if (i > 0)
                {
                    object oo = SqlHelper.ExecuteScalar(SqlHelper.connstrpark, CommandType.Text, "select Balance from Card where id=@id", new SqlParameter("@id", Int32.Parse(context.Request["cardid"].ToString())));
                    if (oo != null)
                    {
                        if (oo.ToString() != "")
                        {
                            newbalance = Int32.Parse(oo.ToString()) + Int32.Parse(context.Request["price"].ToString());
                            SqlParameter[] spnode = new SqlParameter[] {
                       new SqlParameter("@NewBalance",newbalance),
                       new SqlParameter("@id",Int32.Parse(context.Request["cardid"].ToString()))
                       };
                            i = SqlHelper.ExecuteUpdate(SqlHelper.connstrpark, CommandType.Text, "update Card set Balance=@NewBalance where id=@id", spnode);

                        }
                    }
                }

            }
            context.Response.ContentType = "text/plain";
            context.Response.Write(i.ToString());
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