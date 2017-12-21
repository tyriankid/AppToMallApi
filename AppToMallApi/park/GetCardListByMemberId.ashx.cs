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
    /// GetCardListByMemberId 的摘要说明
    /// </summary>
    public class GetCardListByMemberId : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string str = "";
            if (context.Request["MemberId"] != null)
            {
                DataTable dt = SqlHelper.ExecuteDataTable(SqlHelper.connstrpark, CommandType.Text, "select a.*,b.CardName from Card a,CardType b where a.CardTypeId=b.id and MemberId=@MemberId order by a.id desc", new SqlParameter("@MemberId", context.Request["MemberId"].ToString()));
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        List<Card> list = new List<Card>();
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            Card entity = new Card();
                            entity.Balance = dt.Rows[i]["Balance"].ToString();
                            entity.CardNumber = dt.Rows[i]["CardNumber"].ToString();
                            entity.CardTypeId =  Int32.Parse(dt.Rows[i]["CardTypeId"].ToString());
                            entity.CardTypeName = dt.Rows[i]["CardName"].ToString();
                            entity.id = Int32.Parse(dt.Rows[i]["id"].ToString());
                            list.Add(entity);
                        }
                        str = JsonConvert.SerializeObject(list);
                    
                    }
                }
            }
            context.Response.ContentType = "text/plain";
            context.Response.Write(str);
        }

        public class Card
        {
            public int id;
            public string CardNumber;
            public string Balance;
            public string CardTypeName;
            public int CardTypeId;
        
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