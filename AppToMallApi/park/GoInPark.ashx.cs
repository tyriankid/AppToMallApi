using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using UiFangSqlHelper;

namespace FangApi.park
{
    /// <summary>
    /// GoInPark 的摘要说明
    /// </summary>
    public class GoInPark : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            int i = 0;
            if (context.Request["cardid"] != null && context.Request["cardnum"] != null && context.Request["price"] != null)
            {
                int newbalance = 0;
                SqlParameter[] sp = new SqlParameter[] {
            new SqlParameter("@CardId", Int32.Parse(context.Request["cardid"].ToString())),
            new SqlParameter("@CardNum",context.Request["cardnum"].ToString()),
            new SqlParameter("@AddPrice", context.Request["price"].ToString()),
            new SqlParameter("@CreateTime",DateTime.Now),
            new SqlParameter("@UpdateUser",88888),
            new SqlParameter("@UpdateUserName","闸机设备"),
            new SqlParameter("@RechargeFrom","闸机设备"),
            new SqlParameter("@Mark","扫码入场")
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