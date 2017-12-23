using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UiFangSqlHelper;
using System.Data;
using System.Data.SqlClient;

namespace FangApi.park
{
    /// <summary>
    /// InShop 的摘要说明
    /// </summary>
    public class InShop : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            int i = 0;
            if (context.Request["date"] != null && context.Request["time"] != null && context.Request["memberid"] != null && context.Request["shopid"] != null && context.Request["shopname"] != null)
            {

                int num = 0;
                object oo = SqlHelper.ExecuteScalar(SqlHelper.connstrpark, CommandType.Text, "select count(*) from InShop where InShopTime=@InShopTime", new SqlParameter("@InShopTime", context.Request["date"].ToString()));
                if (oo != null)
                {
                    if (oo.ToString() != "")
                    {
                        num = Int32.Parse(oo.ToString());
                    }
                
                }
                if (num <= 1000)
                {
                    string cardnumber = "";
                    if (context.Request["cardnumber"] != null)
                    {
                        cardnumber = context.Request["cardnumber"].ToString();
                    }
                    SqlParameter[] sp = new SqlParameter[] { 
                new SqlParameter("@InShopTime",Convert.ToDateTime(context.Request["date"].ToString()+" "+context.Request["time"].ToString())),
                new SqlParameter("@InShopName","武汉艾宝特"),
                new SqlParameter("@InShopId",1),
                new SqlParameter("@MemberId",Int32.Parse(context.Request["memberid"].ToString())),
                new SqlParameter("@CardNumber",cardnumber)
                };

                    i = SqlHelper.ExecuteUpdate(SqlHelper.connstrpark, CommandType.Text, " insert InShop(InShopTime,InShopName,InShopId,MemberId,CardNumber) values(@InShopTime,@InShopName,@InShopId,@MemberId,@CardNumber)", sp);
                    if (Int32.Parse(context.Request["memberid"].ToString()) == 0)
                    {
                        SqlParameter[] spuse = new SqlParameter[] { 
                    new SqlParameter("@CardUseTime",Convert.ToDateTime(context.Request["date"].ToString()+" "+context.Request["time"].ToString())),
                    new SqlParameter("@CardNumber",cardnumber)
                    };
                        SqlHelper.ExecuteUpdate(SqlHelper.connstrpark, CommandType.Text, "update TempCard set CardState=1,CardUseTime=@CardUseTime where CardNumber=@CardNumber", spuse);

                    }
                }
                else {
                    i = 9999999;
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