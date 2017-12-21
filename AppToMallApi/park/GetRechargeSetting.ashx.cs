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
    /// GetRechargeSetting 的摘要说明
    /// </summary>
    public class GetRechargeSetting : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string str = "";
            if (context.Request["cardtypeid"] != null)
            {
                List<Setting> list = null;
                DataTable dt = SqlHelper.ExecuteDataTable(SqlHelper.connstrpark, CommandType.Text, "select * from RechargeSetting where CardTypeId=@CardTypeId order by AddPrice asc", new SqlParameter("@CardTypeId",context.Request["cardtypeid"].ToString()));
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        list = new List<Setting>();
                        for (int i = 0; i < dt.Rows.Count;i++ )
                        {
                            Setting entity = new Setting();
                            entity.AddPrice = Convert.ToDecimal(dt.Rows[i]["AddPrice"].ToString());
                            entity.CardTypeId = Int32.Parse(dt.Rows[i]["CardTypeId"].ToString());
                            list.Add(entity);
                        }
                        str = JsonConvert.SerializeObject(list);
                    
                    }
                }
            
            }
            context.Response.ContentType = "text/plain";
            context.Response.Write(str);
        }
        public class Setting
        {
            public int id;
            public decimal AddPrice;
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