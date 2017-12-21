using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using MallSdk;
using MallSdk.Request;
using YCHLitJson;
using Newtonsoft.Json;

namespace MallSdk
{
    public class BaseRequestGame
    {
        //验证串
        public string Sign { get; set; }

        /// <summary>
        /// 时间戳(10分钟)
        /// </summary>
        public long TS { get; set; }

        /// <summary>
        /// 芯片号
        /// </summary>
        public string ICNumber { get; set; }

        /// <summary>
        /// 扣费码
        /// </summary>
        public string MachineCode { get; set; }

        public T SetSign<T>(T o, string appId, string secretKey) where T : BaseRequestGame
        {
            o.TS = Getmillis();
            var param = GetDictionary(o);
            param.Add("secretkey", secretKey);
            var signs = GenerateSign(param);
            o.Sign = signs;
            return o;
        }

        private static Dictionary<string, string> GetDictionary(object o)
        {
            var sortedParams = new Dictionary<string, string>();
            if (o == null)
                return sortedParams;
            var type = o.GetType();
            foreach (var p in type.GetProperties())
            {
                var name = p.Name.ToLower();
                var value = p.GetValue(o, null);

                if (p.PropertyType.IsValueType || p.PropertyType.Name.StartsWith("String"))
                {
                    if (p.PropertyType.Name == "Decimal")
                    {
                        if (value.ToString().Split('.').Length == 1)
                        {
                            sortedParams.Add(name, Convert.ToDecimal(value).ToString("f1"));
                        }
                        else
                        {
                            sortedParams.Add(name, value.ToString());
                        }
                    }
                }
                else if (p.PropertyType.IsGenericType || p.PropertyType.IsClass)
                {
                    //sortedParams.Add(name, value == null ? "" : JsonMapper.ToJson(value));
                    sortedParams.Add(name, value == null ? "" : JsonConvert.SerializeObject(value));
                }
            }
            return sortedParams;
        }
        private static long Getmillis()
        {
            long currenttimemillis = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
            return currenttimemillis;
        }
        private static string GenerateSign(Dictionary<string, string> param, string secretkeyName = "secretkey")
        {
            try
            {
                if (param == null || secretkeyName == null) return "";

                //排序字典
                SortedDictionary<string, string> dict = new SortedDictionary<string, string>();
                // 1.参数KEY转换为小写
                foreach (string key in param.Keys)
                {
                    string k = key.ToLower();
                    if (k == "sign") continue; //删除sign参数
                    dict.Add(k, param[key]);
                }
                // 2.将参数名和参数值组成字符串，将secretkey加到字符串前后
                string vsecret = dict[secretkeyName.ToLower()];
                StringBuilder sb = new StringBuilder();
                sb.Append(vsecret); //将secretkey加到字符串前后
                foreach (string paramname in dict.Keys)
                {
                    if (paramname == secretkeyName.ToLower()) continue; //不要将secretkey当成参数
                    sb.Append(paramname);
                    sb.Append(dict[paramname] ?? "");
                }
                sb.Append(vsecret); //将secretkey加到字符串前后
                // 3.用MD5算法生成签名
                string signResult = GetMd5(sb.ToString(), "UTF-8").ToUpper();
                return signResult;
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        private static string GetMd5(string dataStr, string codeType)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            var bytes = md5.ComputeHash(Encoding.GetEncoding(codeType).GetBytes(dataStr));
            var sb = new StringBuilder(32);
            foreach (var b in bytes)
            {
                sb.Append(b.ToString("x").PadLeft(2, '0'));
            }
            return sb.ToString();
        }
    }
}
