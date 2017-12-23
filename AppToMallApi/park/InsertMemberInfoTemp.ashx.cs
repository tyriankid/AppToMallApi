using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using UiFangSqlHelper;
using System.Data;

namespace FangApi.park
{
    /// <summary>
    /// InsertMemberInfoTemp 的摘要说明
    /// </summary>
    public class InsertMemberInfoTemp : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            int i = 0;
            int memberid = 0;
            if (context.Request.QueryString["OpenId"] != null && context.Request.QueryString["Country"] != null && context.Request.QueryString["City"] != null && context.Request.QueryString["Province"] != null && context.Request.QueryString["AvatarUrl"] != null && context.Request.QueryString["WxNickName"] != null && context.Request.QueryString["CardType"] != null && context.Request.QueryString["ChildSex"] != null && context.Request.QueryString["ChildBirthday"] != null && context.Request.QueryString["ChildName"] != null && context.Request.QueryString["Phone"] != null && context.Request.QueryString["Birthday"] != null && context.Request.QueryString["Sex"] != null && context.Request.QueryString["Identification"] != null && context.Request.QueryString["Mail"] != null && context.Request.QueryString["CardId"] != null && context.Request.QueryString["MemberId"] != null && context.Request.QueryString["Name"] != null)
            {


                if (context.Request.QueryString["MemberId"].ToString() != "0")
                {
                    memberid = Int32.Parse(context.Request.QueryString["MemberId"].ToString());
                    string sql = " update Member set Name=@Name,Mail=@Mail,Identification=@Identification,Sex=@Sex,Birthday=@Birthday,Phone=@Phone,UpdateTime=@UpdateTime,UpdateUserId=@UpdateUserId,ChildName=@ChildName where id=@id";
                    SqlParameter[] spmember = new SqlParameter[]{
             new SqlParameter("@Name",context.Request.QueryString["Name"].ToString()),
             new SqlParameter("@Mail",context.Request.QueryString["Mail"].ToString()),
             new SqlParameter("@Identification",context.Request.QueryString["Identification"].ToString()),
             new SqlParameter("@Sex",context.Request.QueryString["Sex"].ToString()),
             new SqlParameter("@Birthday",context.Request.QueryString["Birthday"].ToString()),
             new SqlParameter("@Phone",context.Request.QueryString["Phone"].ToString()),
             new SqlParameter("@CreateTime",DateTime.Now),
             new SqlParameter("@UpdateUser","微信活动卡绑定"),
             new SqlParameter("@UpdateUserId","999999"),
             new SqlParameter("@UpdateTime",DateTime.Now),
              new SqlParameter("@ChildName",context.Request.QueryString["ChildName"].ToString()),
             new SqlParameter("@ChildBirthday",context.Request.QueryString["ChildBirthday"].ToString()),
               new SqlParameter("@ChildSex",context.Request.QueryString["ChildSex"].ToString()),
               new SqlParameter("@id",context.Request.QueryString["MemberId"].ToString())
             };
                    i = SqlHelper.ExecuteUpdate(SqlHelper.connstrpark, CommandType.Text, sql, spmember);

                }
                else
                {
                    string sqlmember = @"insert Member(Name,Mail,Identification
           ,Sex,Birthday,Phone,OtherInfo,Mark,CreateTime,UpdateUser,UpdateUserId,UpdateTime,MemberType
           ,WxNickName,AvatarUrl,Province,City,Country,OpenId ,ChildName,ChildBirthday,ChildSex) values(@Name,@Mail,@Identification
           ,@Sex,@Birthday,@Phone,@OtherInfo,@Mark,@CreateTime,@UpdateUser,@UpdateUserId,@UpdateTime,@MemberType
           ,@WxNickName,@AvatarUrl,@Province,@City,@Country,@OpenId ,@ChildName,@ChildBirthday,@ChildSex)";
                    SqlParameter[] spmember = new SqlParameter[]{
             new SqlParameter("@Name",context.Request.QueryString["Name"].ToString()),
             new SqlParameter("@Mail",context.Request.QueryString["Mail"].ToString()),
             new SqlParameter("@Identification",context.Request.QueryString["Identification"].ToString()),
             new SqlParameter("@Sex",context.Request.QueryString["Sex"].ToString()),
             new SqlParameter("@Birthday",context.Request.QueryString["Birthday"].ToString()),
             new SqlParameter("@Phone",context.Request.QueryString["Phone"].ToString()),
             new SqlParameter("@OtherInfo",""),
             new SqlParameter("@Mark",""),
             new SqlParameter("@CreateTime",DateTime.Now),
             new SqlParameter("@UpdateUser","微信活动卡绑定"),
             new SqlParameter("@UpdateUserId","999999"),
             new SqlParameter("@UpdateTime",DateTime.Now),
             new SqlParameter("@MemberType",context.Request.QueryString["CardType"].ToString()),
             new SqlParameter("@WxNickName",context.Request.QueryString["WxNickName"].ToString()),
             new SqlParameter("@AvatarUrl",context.Request.QueryString["AvatarUrl"].ToString()),
              new SqlParameter("@Province",context.Request.QueryString["Province"].ToString()),
             new SqlParameter("@City",context.Request.QueryString["City"].ToString()),
              new SqlParameter("@Country",context.Request.QueryString["Country"].ToString()),
             new SqlParameter("@OpenId",context.Request.QueryString["OpenId"].ToString()),
              new SqlParameter("@ChildName",context.Request.QueryString["ChildName"].ToString()),
             new SqlParameter("@ChildBirthday",context.Request.QueryString["ChildBirthday"].ToString()),
               new SqlParameter("@ChildSex",context.Request.QueryString["ChildSex"].ToString())
             };
                    memberid = SqlHelper.InsertAndReturnID(SqlHelper.connstrpark, CommandType.Text, sqlmember, spmember);

                    if (memberid > 0)
                    {
                        SqlParameter[] spcard = new SqlParameter[]{
                  new SqlParameter("@MemberId",memberid),
                  new SqlParameter("@id",context.Request.QueryString["CardId"].ToString())
                       };
                        i = SqlHelper.ExecuteUpdate(SqlHelper.connstrpark, CommandType.Text, "update TempCard set MemberId=@MemberId where id=@id", spcard);
                    }
                }
            }
            context.Response.ContentType = "text/plain";
            context.Response.Write(memberid.ToString());
    
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