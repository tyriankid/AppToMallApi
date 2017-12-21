using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;
using WeiXin.Lib.Core.Models;
using System.IO;
using System.Data;
using UiFangSqlHelper;
using System.Data.SqlClient;

namespace FangApi.park
{
    /// <summary>
    /// GetMemberInfo 的摘要说明
    /// </summary>
    public class GetMemberInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
           string str = "";
           string result = "";
           if (context.Request["str"] != null && context.Request["iv"] != null && context.Request["sessionkey"] != null)
           {
               result = AES_decrypt(context.Request["str"].ToString(), context.Request["sessionkey"].ToString(), context.Request["iv"].ToString());
               phoneinfo entity = JsonConvert.DeserializeObject<phoneinfo>(result);
               if (entity != null)
               {
                   DataTable dt = SqlHelper.ExecuteDataTable(SqlHelper.connstrpark, CommandType.Text, "select * from Card where MemberId in (select id from Member where Phone=@Phone ) order by id desc", new SqlParameter("@Phone", entity.phoneNumber));
                   if (dt != null)
                   {
                       if (dt.Rows.Count > 0)
                       {
                           if (dt.Rows.Count == 1)
                           {
                               result entityresult = new result();
                               entityresult.cardid = Int32.Parse(dt.Rows[0]["id"].ToString());
                               entityresult.memberid = Int32.Parse(dt.Rows[0]["memberid"].ToString());
                               entityresult.cardnum = 1;
                               str = JsonConvert.SerializeObject(entityresult);

                           }
                           else
                           {
                               result entityresult = new result();
                               entityresult.cardid = Int32.Parse(dt.Rows[0]["id"].ToString());
                               entityresult.memberid = Int32.Parse(dt.Rows[0]["memberid"].ToString());
                               entityresult.cardnum = dt.Rows.Count;
                               str = JsonConvert.SerializeObject(entityresult);
                           }
                       }
                   }

               }
           }
                   context.Response.ContentType = "text/plain";
            context.Response.Write(str);
        }
        public class result
        {
            public int memberid;
            public int cardid;
            public int cardnum;
        
        }
        public class phoneinfo
        {
            public string phoneNumber;
            public string purePhoneNumber;
            public string countryCode;
            public watermark watermark;
           
        }
        public class watermark
        {
            public string timestamp;
            public string appid;
        
        }
public string AES_decrypt(string encryptedDataStr, string key, string iv)
        {
            RijndaelManaged rijalg = new RijndaelManaged();
            //-----------------      
            //设置 cipher 格式 AES-128-CBC      

            rijalg.KeySize = 128;

            rijalg.Padding = PaddingMode.PKCS7;
            rijalg.Mode = CipherMode.CBC;

            rijalg.Key = Convert.FromBase64String(key);
            rijalg.IV = Convert.FromBase64String(iv);


            byte[] encryptedData = Convert.FromBase64String(encryptedDataStr);
            //解密      
            ICryptoTransform decryptor = rijalg.CreateDecryptor(rijalg.Key, rijalg.IV);

            string result;

            using (MemoryStream msDecrypt = new MemoryStream(encryptedData))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {

                        result = srDecrypt.ReadToEnd();
                    }
                }
            }

            return result;
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