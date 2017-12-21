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
    /// GetMemberIdByOpenId 的摘要说明
    /// </summary>
    public class GetMemberIdByOpenId : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string str = "";
            if (context.Request["openid"] != null)
            {
                string sql = " select id from Member where OpenId=@OpenId";
                object oo = SqlHelper.ExecuteScalar(SqlHelper.connstrpark, CommandType.Text, sql, new SqlParameter("@OpenId", context.Request["openid"].ToString()));
                if (oo != null)
                {
                    if (oo.ToString() != "")
                    {
                        str = oo.ToString();
                    }
                }
            }
            context.Response.ContentType = "text/plain";
            context.Response.Write(str);
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