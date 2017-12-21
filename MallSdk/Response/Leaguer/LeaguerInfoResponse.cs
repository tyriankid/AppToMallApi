using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallSdk
{
    public class LeaguerInfoResponse : MallResponse
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        public string LeaguerID { get; set; }
        /// <summary>
        /// 是否取卡
        /// </summary>
        public bool IsTake { get; set; }
        /// <summary>
        /// 会员号
        /// </summary>
        public string LeaguerCode { get; set; }
        /// <summary>
        /// 会员等级ID
        /// </summary>
        public string LeaguerLevelID { get; set; }

        /// <summary>
        /// 会员等级名称
        /// </summary>
        public string LeaguerLevelName { get; set; }

        /// <summary>
        /// 会员状态ID
        /// </summary>
        public int LeaguerStatus { get; set; }

        /// <summary>
        /// 会员状态描述
        /// </summary>
        public string LeaguerStatusDesc { get; set; }



        /// <summary>
        /// 真实姓名
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTime? VerifyTime { get; set; }

        ///// <summary>
        ///// 开卡商户ID
        ///// </summary>
        //public string OpenBusiness { get; set; }

        /// <summary>
        /// 开卡商户名称
        /// </summary>
        public string OpenBusinessName { get; set; }

        /// <summary>
        /// 性别,1男0女
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address
        {
            get;
            set;
        }

        /// <summary>
        /// 生日
        /// </summary>

        public DateTime? Birthday
        {
            get;
            set;
        }

        /// <summary>
        /// 邮箱
        /// </summary>

        public string Email
        {
            get;
            set;
        }


        /// <summary>
        /// 身份证
        /// </summary>

        public string IDCard
        {
            get;
            set;
        }

        /// <summary>
        /// 子女姓名
        /// </summary>

        public string ChildName
        {
            get;
            set;
        }

        /// <summary>
        /// 子女生日
        /// </summary>

        public DateTime? ChildBirthday
        {
            get;
            set;
        }

        /// <summary>
        /// 子女性别
        /// </summary>

        public int ChildSex
        {
            get;
            set;
        }

        /// <summary>
        /// 子女2姓名
        /// </summary>

        public string Child2Name
        {
            get;
            set;
        }

        /// <summary>
        /// 子女2生日
        /// </summary>

        public DateTime? Child2Birthday
        {
            get;
            set;
        }

        /// <summary>
        /// 子女2性别
        /// </summary>

        public int Child2Sex
        {
            get;
            set;
        }

        /// <summary>
        /// 电话
        /// </summary>

        public string Phone
        {
            get;
            set;
        }

        /// <summary>
        /// 注册时间
        /// </summary>

        public DateTime RegTime
        {
            get;
            set;
        }

        /// <summary>
        /// 即时通讯号码
        /// </summary>

        public string IMNO
        {
            get;
            set;
        }

        /// <summary>
        /// QQ
        /// </summary>
        public string QQ
        {
            get;
            set;
        }

        /// <summary>
        /// 头像  
        /// </summary>
        public byte[] CA_Photo
        {
            get;
            set;
        }
    }
}
