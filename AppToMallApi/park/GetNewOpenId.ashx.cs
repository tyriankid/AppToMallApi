using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeiXin.Lib.Core.Models;
using Newtonsoft.Json;
namespace FangApi.park
{
    /// <summary>
    /// GetNewOpenId 的摘要说明
    /// </summary>
    public class GetNewOpenId : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string str = "";
            if (context.Request["code"] != null)
            {
                try
                {
                    wxopenid entity = WeiXin.Lib.Core.Helper.WeiXinHelper.GetParkUserSampleInfo(context.Request["code"].ToString());
                    if (entity != null)
                    {
                        str = JsonConvert.SerializeObject(entity);

                    }
                }
                catch (Exception ee)
                {

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