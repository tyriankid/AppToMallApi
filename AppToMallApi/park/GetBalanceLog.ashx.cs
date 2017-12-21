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
    /// GetBalanceLog 的摘要说明
    /// </summary>
    public class GetBalanceLog : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string str = "";
            if (context.Request["cardid"] != null&&context.Request["type"]!=null)
            {
                string sql = "";
                if (context.Request["type"].ToString() == "1")
                {
                    sql = "select * from Recharge where CardId=@CardId order by id desc";
                }
                else
                {
                    sql = "select * from Recharge where CardId=@CardId and AddPrice<0 order by id desc";
                
                }
                DataTable dt = SqlHelper.ExecuteDataTable(SqlHelper.connstrpark, CommandType.Text, sql, new SqlParameter("@CardId", context.Request["cardid"].ToString()));
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        List<Recharge> list = new List<Recharge>();
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            Recharge entity = new Recharge();
                            entity.AddPrice = Convert.ToDecimal(dt.Rows[i]["AddPrice"].ToString());
                            entity.CardNum = dt.Rows[i]["CardNum"].ToString();
                            entity.date = Convert.ToDateTime(dt.Rows[i]["CreateTime"].ToString()).ToString("yyyy-MM-dd");
                            entity.Time = Convert.ToDateTime(dt.Rows[i]["CreateTime"].ToString()).ToString("hh:mm:ss");
                            entity.Mark = dt.Rows[i]["Mark"].ToString();
                            list.Add(entity);
                        }
                        str = JsonConvert.SerializeObject(list);
                    }
                }
            }
            context.Response.ContentType = "text/plain";
            context.Response.Write(str);
        }
        public class Recharge
        {
            public string CardNum;
            public decimal AddPrice;
            public string date;
            public string Time;
            public string Mark;
            public string RechargeFrom;
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