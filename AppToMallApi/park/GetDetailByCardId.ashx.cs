using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using UiFangSqlHelper;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace FangApi.park
{
    /// <summary>
    /// GetDetailByCardId 的摘要说明
    /// </summary>
    public class GetDetailByCardId : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string str = "";
            if (context.Request["cardid"] != null)
            {
                string sql = "select * from Card where id=@id";
                DataTable dt = SqlHelper.ExecuteDataTable(SqlHelper.connstrpark, CommandType.Text, sql, new SqlParameter("@id", context.Request["cardid"].ToString()));
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {

                        card entity = new card();
                        entity.id = Int32.Parse(dt.Rows[0]["id"].ToString());
                        entity.CardTypeId = Int32.Parse(dt.Rows[0]["CardTypeId"].ToString());
                        entity.Balance = Convert.ToDecimal(dt.Rows[0]["Balance"].ToString());
                        entity.CardNumber = dt.Rows[0]["CardNumber"].ToString();
                        entity.CardTypeName = dt.Rows[0]["CardTypeName"].ToString();
                        entity.MemberId = Int32.Parse(dt.Rows[0]["MemberId"].ToString());
                        object oo = SqlHelper.ExecuteScalar(SqlHelper.connstrpark, CommandType.Text, "select count(*) from Recharge where CardId=@CardId and AddPrice<0", new SqlParameter("@CardId", Int32.Parse(context.Request["cardid"].ToString())));
                        if (oo != null)
                        {
                            if (oo.ToString() != "")
                            {
                                entity.AllInTimes = Int32.Parse(oo.ToString());
                            }
                        }
                        if(entity.MemberId!=0)
                        {
                        object oonum = SqlHelper.ExecuteScalar(SqlHelper.connstrpark, CommandType.Text, "select count(*) from Card where MemberId=@MemberId ", new SqlParameter("@MemberId", Int32.Parse(dt.Rows[0]["MemberId"].ToString())));
                       if(oonum!=null)
                       {
                           if(oo.ToString()!="")
                           {
                               entity.CardNum=Int32.Parse(oonum.ToString());
                           
                           }
                           else{
                                 entity.CardNum=1;
                           }
                       }
                       else
                       {
                           entity.CardNum=1;
                       }
                        }
                        else{
                        entity.CardNum=1;
                        }
                            str = JsonConvert.SerializeObject(entity);
                    }
                }

            }
            context.Response.ContentType = "text/plain";
            context.Response.Write(str);
        }
        public class card
        {
            public int id;
            public int CardTypeId;
            public int MemberId;
            public string CardNumber;
            public string CardTypeName;
            public decimal Balance;
            public int AllInTimes;
            public int CardNum;
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