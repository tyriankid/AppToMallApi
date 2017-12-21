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

                SqlParameter[] sp = new SqlParameter[] { 
                new SqlParameter("@InShopTime",Convert.ToDateTime(context.Request["date"].ToString()+" "+context.Request["time"].ToString())),
                new SqlParameter("@InShopName","武汉艾宝特"),
                new SqlParameter("@InShopId",1),
                new SqlParameter("@MemberId",Int32.Parse(context.Request["memberid"].ToString())),
                };

                i = SqlHelper.ExecuteUpdate(SqlHelper.connstrpark, CommandType.Text, " insert InShop(InShopTime,InShopName,InShopId,MemberId) values(@InShopTime,@InShopName,@InShopId,@MemberId)",sp);
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