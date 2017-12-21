using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UiFangSqlHelper;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace FangApi.park
{
    /// <summary>
    /// BindCardByIdentification 的摘要说明
    /// </summary>
    public class BindCardByIdentification : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {

            string str = "";
            if (context.Request.QueryString["OpenId"] != null && context.Request.QueryString["CardNumber"] != null && context.Request.QueryString["Phone"] != null)
            {
                SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@Identification",context.Request.QueryString["CardNumber"]),
                new SqlParameter("@Phone",context.Request.QueryString["Phone"])
                };
                DataTable dt = SqlHelper.ExecuteDataTable(SqlHelper.connstrpark, CommandType.Text, "select top 1 a.id,a.MemberId from Card a inner join Member b on a.MemberId=b.id and a.CardNumber=@CardNumber and b.Phone=@Phone order by a.UpdateTime desc", sp);
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        SqlParameter[] spcard = new SqlParameter[] { 
                        new SqlParameter("@OpenId",context.Request.QueryString["OpenId"]),
                        new SqlParameter("@id",Int32.Parse(dt.Rows[0]["id"].ToString()))
                        };
                        int i = SqlHelper.ExecuteUpdate(SqlHelper.connstrpark, CommandType.Text, " update Card set OpenId=@OpenId where id=@id", spcard);
                        if (i > 0)
                        {
                            Card entity = new Card();
                            entity.cardid = Int32.Parse(dt.Rows[0]["id"].ToString());
                            entity.memberid = Int32.Parse(dt.Rows[0]["MemberId"].ToString());
                            str = JsonConvert.SerializeObject(entity);
                        }
                    }

                }

            }
            context.Response.ContentType = "text/plain";
            context.Response.Write(str);
        }
        public class Card
        {
            public int memberid;
            public int cardid;

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