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
    /// GetCardType 的摘要说明
    /// </summary>
    public class GetCardType : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            List<CardType> list = null;
            string str = "";
            DataTable dt = SqlHelper.ExecuteDataTable(SqlHelper.connstrpark, CommandType.Text, "select * from  CardType order by id asc");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    list = new List<CardType>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        CardType entity = new CardType();
                        entity.CardLevel = dt.Rows[i]["CardLevel"].ToString();
                        entity.CardMark = dt.Rows[i]["CardMark"].ToString();
                        entity.id = Int32.Parse(dt.Rows[i]["id"].ToString());
                        entity.CardName = dt.Rows[i]["CardName"].ToString();
                        entity.CardPrice = Convert.ToDecimal(dt.Rows[i]["CardPrice"].ToString());
                        if (i == 0)
                        {
                            entity.ischeck = true;
                        }
                        else { entity.ischeck = false; }
                        list.Add(entity);
                    }
                    str = JsonConvert.SerializeObject(list);
                
                }
            
            }
            context.Response.ContentType = "text/plain";
            context.Response.Write(str);
        }
        public class CardType
        {
            public int id;
            public string CardName;
            public decimal CardPrice;
            public string CardMark;
            public string CardLevel;
            public bool ischeck;

        
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