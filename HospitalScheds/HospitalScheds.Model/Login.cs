using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    /// <summary>
    /// 登录表
    /// </summary>
    public class Login 
    {
        public int Id { get; set; }                         //主键id
        public string Name { get; set; }                    //用户名
        public string Passwold { get; set; }                //密码
    }
}
