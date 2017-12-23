using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using UiFangSqlHelper;
using System.Data;
using System.Data.SqlClient;



namespace FangApi.park
{
    /// <summary>
    /// GetTempCardInfo 的摘要说明
    /// </summary>
    public class GetTempCardInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string str = "";
            if (context.Request["cardnumber"] != null)
            {
                Card entity = new Card();
                DataTable dt = SqlHelper.ExecuteDataTable(SqlHelper.connstrpark, CommandType.Text, "select * from TempCard where CardNumber=@CardNumber", new SqlParameter("@CardNumber", context.Request["cardnumber"].ToString()));
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        entity.id = Int32.Parse(dt.Rows[0]["id"].ToString());
                        entity.CardNumber = dt.Rows[0]["CardNumber"].ToString();
                        entity.State = Int32.Parse(dt.Rows[0]["CardState"].ToString());
                        entity.UseTime = Convert.ToDateTime(dt.Rows[0]["CardUseTime"].ToString()).ToString("yyyy-MM-dd");
                        str = JsonConvert.SerializeObject(entity);
                    }
                
                }
            
            }
            context.Response.ContentType = "text/plain";
            context.Response.Write(str);
        }
        public class Card
        {
            public int id;
            public int State;
            public string UseTime;
            public string CardNumber;
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