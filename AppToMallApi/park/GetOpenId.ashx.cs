using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeiXin.Lib.Core.Models;
using Newtonsoft.Json;

namespace FangApi.park
{
    /// <summary>
    /// GetOpenId 的摘要说明
    /// </summary>
    public class GetOpenId : IHttpHandler
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
                        if (entity.openid != "")
                        {
                            str =  entity.openid;

                        }

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