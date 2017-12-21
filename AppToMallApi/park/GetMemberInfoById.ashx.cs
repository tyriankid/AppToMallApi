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
    /// GetMemberInfoById 的摘要说明
    /// </summary>
    public class GetMemberInfoById : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string str = "";
            if (context.Request["MemberId"] != null)
            {
                DataTable dt = SqlHelper.ExecuteDataTable(SqlHelper.connstrpark,CommandType.Text,"select * from Member where id=@id" ,new SqlParameter("@id",context.Request["MemberId"].ToString()));
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        Member entity = new Member();
                        entity.id = Int32.Parse(dt.Rows[0]["id"].ToString());
                        entity.AvatarUrl = dt.Rows[0]["AvatarUrl"].ToString();
                        entity.Birthday = dt.Rows[0]["Birthday"].ToString();
                        entity.ChildBirthday = dt.Rows[0]["ChildBirthday"].ToString();
                        entity.ChildName = dt.Rows[0]["ChildName"].ToString();
                        entity.ChildSex = Int32.Parse(dt.Rows[0]["ChildSex"].ToString());
                        entity.City = dt.Rows[0]["City"].ToString();
                        entity.Country = dt.Rows[0]["Country"].ToString();
                        entity.CreateTime = Convert.ToDateTime(dt.Rows[0]["CreateTime"].ToString()).ToString("yyyy-MM-dd");
                        entity.Identification = dt.Rows[0]["Identification"].ToString();
                        entity.Mail = dt.Rows[0]["Mail"].ToString();
                        entity.Mark = dt.Rows[0]["Mark"].ToString();
                        entity.MemberType = Int32.Parse(dt.Rows[0]["MemberType"].ToString());
                        entity.Name = dt.Rows[0]["Name"].ToString();
                        entity.OpenId = dt.Rows[0]["OpenId"].ToString();
                        entity.OtherInfo = dt.Rows[0]["OtherInfo"].ToString();
                        entity.Phone = dt.Rows[0]["Phone"].ToString();
                        entity.Province = dt.Rows[0]["Province"].ToString();
                        entity.Sex = Int32.Parse(dt.Rows[0]["Sex"].ToString());
                        str = JsonConvert.SerializeObject(entity);
                    }
                }
            
            }
            context.Response.ContentType = "text/plain";
            context.Response.Write(str);
        }
        public class Member
        {
            public int id;
             public string Name;
            public string Mail;
            public string Identification;
           public int Sex;
           public string Birthday;
           public string Phone;
           public string OtherInfo;
           public string Mark;
           public string CreateTime;
           public string UpdateUser;
           public int UpdateUserId;
           public string UpdateTime;
           public int MemberType;
           public string WxNickName;
           public string AvatarUrl;
           public string Province;
           public string City;
           public string Country;
           public string OpenId;
           public string ChildName;
           public string ChildBirthday;
           public int ChildSex;
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