using System;
using System.Collections.Generic;
using MallSdk.Request;
using MallSdk.Util;
using System.Linq;
using YCHLitJson;

namespace MallSdk
{
    /// <summary>
    /// Mall客户端。
    /// </summary>
    public class DefaultMallClient : IMallClient
    {
        /// <summary>
        /// 渠道编号
        /// </summary>
        private string AppID { get; set; }
        private string charset;
        private string serverUrl;
        private WebUtils webUtils;

        private string privateKeyPem;

        #region DefaultMallClient Constructors

        public DefaultMallClient(string serverUrl, string privateKeyPem, string appID)
        {
            this.AppID = appID;
            this.serverUrl = serverUrl;
            this.privateKeyPem = privateKeyPem;
            this.webUtils = new WebUtils();
        }
        public void SetTimeout(int timeout)
        {
            webUtils.Timeout = timeout;
        }

        #endregion

        #region IMallClient Members
        public T Execute<T>(IMallRequest<T> request) where T : MallResponse
        {
            this.charset = "utf-8";
            // 添加协议级请求参数
            //var txtParams = GetNameValue(request);
            //txtParams.Add("AppID", this.AppID);
            //txtParams.Add("TS", SetMallSign.Getmillis().ToString());
            //// 添加签名参数
            //txtParams.Add("Sign", SetMallSign.GetSing(txtParams, privateKeyPem));

            var type = request.GetType();
            var customAttributes = type.GetCustomAttributes(true);
            var routePath = "";
            foreach (var attr in customAttributes.OfType<MallRouteAttribute>())
            {
                routePath = attr.Path;
            }
            string response = webUtils.DoPost(this.serverUrl+ routePath, request, this.charset);
            var reader = new JsonReader(response);
            var res = JsonMapper.ToObject<T>(reader);
            return res;
        }
        #endregion
        private Dictionary<string, string> GetNameValue(object o)
        {
            var parms = new Dictionary<string, string>();
            try
            {
                Type type = o.GetType();
                var myFields = type.GetProperties();
                foreach (var p in myFields)
                {
                    var name = p.Name;
                    var value = p.GetValue(o, null);
                    if (p.PropertyType.IsValueType || p.PropertyType.Name.StartsWith("String"))
                    {
                        parms.Add(name, value == null ? "" : value.ToString());
                    }
                    else if (p.PropertyType.IsGenericType || p.PropertyType.IsClass)
                    {
                        parms.Add(name, value == null ? "" : JsonMapper.ToJson(value));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : {0}", e.Message);
            }
            return parms;
        }
    }
}
