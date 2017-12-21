using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using UiFangSqlHelper;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Text;
using WeiXin.Lib.Core.Models;


namespace FangApi.park
{
    /// <summary>
    /// BuyCard 的摘要说明
    /// </summary>
    public class BuyCard : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string str = "";
            if (context.Request.QueryString["OpenId"] != null && context.Request.QueryString["CardTypeId"] != null && context.Request.QueryString["CardTypeName"] != null && context.Request.QueryString["Balance"] != null)
            {
                string cardnumber = "";
                object oo = SqlHelper.ExecuteScalar(SqlHelper.connstrpark,CommandType.Text,"select count(*) from Card");
                int memberid = 0;
                if (oo != null)
                {
                    if (oo.ToString() != "")
                    {
                        memberid = Int32.Parse(oo.ToString());
                    }
                
                }
                if (memberid < 10)
                {
                    cardnumber = "0000" + memberid.ToString();

                }
                else if (memberid >= 10 && memberid < 100)
                {
                    cardnumber = "000" + memberid.ToString();
                }
                else if (memberid >= 100 && memberid < 1000)
                {
                    cardnumber = "00" + memberid.ToString();
                }
                else if (memberid >= 1000 && memberid < 10000)
                {
                    cardnumber = "0" + memberid.ToString();
                }
                else if (memberid >= 10000 && memberid < 100000)
                {
                    cardnumber = memberid.ToString();
                }


                int member = 0;
                object oomember = SqlHelper.ExecuteScalar(SqlHelper.connstrpark, CommandType.Text, "select * from Member where OpenId=@OpenId order by CreateTime desc", new SqlParameter("@OpenId", context.Request.QueryString["OpenId"].ToString()));
                if (oomember != null)
                {
                    if (oomember.ToString() != "")
                    {
                        member = Int32.Parse(oomember.ToString());
                    }
                
                }
                SqlParameter[] sp = new SqlParameter[] { 
            new SqlParameter("@CardNumber","855833866"+cardnumber),
            new SqlParameter("@CardTypeId",context.Request.QueryString["CardTypeId"].ToString()),
            new SqlParameter("@CardTypeName",context.Request.QueryString["CardTypeName"].ToString()),
            new SqlParameter("@UserId", 999999),
             new SqlParameter("@Balance",context.Request.QueryString["Balance"].ToString()),
     new SqlParameter("@DefaultMoney",context.Request.QueryString["Balance"].ToString()),
         new SqlParameter("@CreateTime",DateTime.Now),
           new SqlParameter("@UpdateTime",DateTime.Now),
             new SqlParameter("@UserName","微信直购"),
             new SqlParameter("@CardFrom","微信小程序"),
             new SqlParameter("@MemberId",member),
             new SqlParameter("@OpenId",context.Request.QueryString["OpenId"].ToString())
        };
                 
                string sql = @" insert Card(CardFrom,OpenId,CardNumber,CardTypeId,CardTypeName,UserId,Balance,DefaultMoney,CreateTime,UpdateTime,MemberId,UserName)
                    values(@CardFrom,@OpenId,@CardNumber,@CardTypeId,@CardTypeName,@UserId,@Balance,@DefaultMoney,@CreateTime,@UpdateTime,@MemberId,@UserName)";
                int i = SqlHelper.InsertAndReturnID(SqlHelper.connstrpark, CommandType.Text, sql, sp);
                if (i > 0) {
                    Card entity = new Card();
                    entity.id = i;
                    entity.CardNumber = "855833866" + cardnumber;
                    entity.MemberId = member;
                    entity.CardType = Int32.Parse(context.Request.QueryString["CardTypeId"].ToString());
                    str = JsonConvert.SerializeObject(entity);
                    SqlParameter[] splog = new SqlParameter[] { 
                     new SqlParameter("@CardId",i),
                     new SqlParameter("@CardNum","855833866" + cardnumber),
                     new SqlParameter("@AddPrice",context.Request.QueryString["Balance"].ToString()),
                     new SqlParameter("@CreateTime",DateTime.Now),
                     new SqlParameter("@UpdateUser",999999),
                     new SqlParameter("@UpdateUserName","微信用户"),
                         new SqlParameter("@RechargeFrom","乐园小程序"),
                          new SqlParameter("@Mark","小程序购卡"),
                    };
                    string sqllog = @"insert Recharge(CardId,CardNum,AddPrice,CreateTime,UpdateUser,UpdateUserName,RechargeFrom,Mark)
                                    values(@CardId,@CardNum,@AddPrice,@CreateTime,@UpdateUser,@UpdateUserName,@RechargeFrom,@Mark)";
                    SqlHelper.ExecuteUpdate(SqlHelper.connstrpark, CommandType.Text,sqllog,splog);
                }
            }
            context.Response.ContentType = "text/plain";
            context.Response.Write(str);
        }
        public class Card
        {
            public int id;
            public int CardType;
            public string CardNumber;
            public int MemberId;
           
        }

        public string SendMsg(string openId, string formid)
        {

            ///获取token
            ///
            string accesstoken = AccessToken.ParkNewInstance().Access_Token;
            //string accesstoken = "ttd6uBdJ6DHyB8q40xVblaG_XHFOenou36Dris_yEzKrwaXbD6A9WqSnXCaNIbfXvRwfABoP6_ZdJL69J9EZ_oAGJreXU6cq-PFd2i_ZflZfpoZbNuxcX6Bh53tcBzMoYXDjAJAEDJ";
            ///发送模版消息
            string url = string.Format("https://api.weixin.qq.com/cgi-bin/message/wxopen/template/send?access_token={0}", accesstoken);
            string postData = "";

            postData = "{ \"touser\":\"" + openId + "\",\"template_id\":\"Y7ChdRpWoox8UgRZWxDx-ijLmcqftUQaQ-Zw3wyJK7I\",\"page\":\"pages/index/index\",\"form_id\":\"" + formid + "\", \"data\":{\"keyword1\":{\"value\":\"" + "2017010101011" + "\",\"color\":\"#173177\"},\"keyword2\":{\"value\":\"" + DateTime.Now + "\",\"color\":\"#173177\"},\"keyword3\":{\"value\":\"" + "这是地点" + "\",\"color\":\"#173177\"},\"keyword4\":{\"value\":\"" + "这是描述" + "\",\"color\":\"#173177\"} } }";


            string strJson = HttpPostData(url, postData);
            return strJson;

        }
        /// <summary>
        /// Post请求
        /// </summary>
        /// <param name="posturl">URL</param>
        /// <param name="postData">请求数据</param>
        /// <returns></returns>
        public static string HttpPostData(string posturl, string postData)
        {
            Stream outstream = null;
            Stream instream = null;
            StreamReader sr = null;
            HttpWebResponse response = null;
            HttpWebRequest request = null;
            Encoding encoding = Encoding.UTF8;
            byte[] data = encoding.GetBytes(postData);
            // 准备请求...
            try
            {
                // 设置参数
                request = WebRequest.Create(posturl) as HttpWebRequest;
                CookieContainer cookieContainer = new CookieContainer();
                request.CookieContainer = cookieContainer;
                request.AllowAutoRedirect = true;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;
                outstream = request.GetRequestStream();
                outstream.Write(data, 0, data.Length);
                outstream.Close();
                //发送请求并获取相应回应数据
                response = request.GetResponse() as HttpWebResponse;
                //直到request.GetResponse()程序才开始向目标网页发送Post请求
                instream = response.GetResponseStream();
                sr = new StreamReader(instream, encoding);
                //返回结果网页（html）代码
                string content = sr.ReadToEnd();
                string err = string.Empty;

                return content;
            }
            catch (Exception ex)
            {
                string err = ex.Message;


                return err;
            }
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