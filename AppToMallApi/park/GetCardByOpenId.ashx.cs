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
    /// GetCardByOpenId 的摘要说明
    /// </summary>
    public class GetCardByOpenId : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string str = "";
            if (context.Request["openid"] != null)
            {
             
                DataTable dt = SqlHelper.ExecuteDataTable(SqlHelper.connstrpark,CommandType.Text,"select * from Card where OpenId=@OpenId order by CreateTime desc",new SqlParameter("@OpenId",context.Request["openid"].ToString()));
                if(dt!=null)
                {
                    if(dt.Rows.Count>0)
                    {
          CardInfo entity=new CardInfo();
                        entity.id=Int32.Parse(dt.Rows[0]["id"].ToString());
                        entity.MemberId=Int32.Parse(dt.Rows[0]["MemberId"].ToString());
                        str=JsonConvert.SerializeObject(entity);
                    }
                }
            
            }
            context.Response.ContentType = "text/plain";
            context.Response.Write(str);
        }
        public class CardInfo
        {
            public int id;
            public int MemberId;
        
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