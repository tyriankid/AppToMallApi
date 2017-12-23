using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using UiFangSqlHelper;
using Newtonsoft.Json;

namespace FangApi.park
{
    /// <summary>
    /// GetTempCard 的摘要说明
    /// </summary>
    public class GetTempCard : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string str = "";
            if (context.Request.QueryString["CardNumber"] != null)
            {
                DataTable dt = SqlHelper.ExecuteDataTable(SqlHelper.connstrpark, CommandType.Text, "select * from TempCard where CardNumber=@CardNumber ", new SqlParameter("@CardNumber", context.Request.QueryString["CardNumber"].ToString()));
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        
                        TempCard entity = new TempCard();
                        entity.CardNumber = dt.Rows[0]["CardNumber"].ToString();
                        entity.CardState = Int32.Parse(dt.Rows[0]["CardState"].ToString());
                        entity.CardUseTime = dt.Rows[0]["CardUseTime"].ToString();
                        entity.MemberId = Int32.Parse(dt.Rows[0]["MemberId"].ToString());
                        entity.id = Int32.Parse(dt.Rows[0]["id"].ToString());
                        str = JsonConvert.SerializeObject(entity);
                    }
                
                }
            }
            context.Response.ContentType = "text/plain";
            context.Response.Write(str);
        }
        public class TempCard
        {
            public int id;
            public string CardNumber;
            public int MemberId;
            public int CardState;
            public string CardUseTime;
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