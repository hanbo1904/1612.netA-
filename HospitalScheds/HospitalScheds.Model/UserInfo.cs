using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    /// <summary>
    /// 用户表
    /// </summary>
   public class UserInfo 
    {
        public int Id { get; set; }//Id
        public string UserName { get; set; }//用户名
        public string Pwd { get; set; }//密码
        public string RoleName { get; set; }//角色名称
        public int IsUse { get; set; }//状态
        public string LoginName { get; set; }//登录名
        public string CreatePerson { get; set; }//创建人
        public DateTime CreateTime { get; set; }//创建时间
    }
}
