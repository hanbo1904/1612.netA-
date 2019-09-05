using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    /// <summary>
    /// 角色权限关联表
    /// </summary>
    public class UserRole
    {
        public int Id { get; set; }//Id
        public int Use_Id { get; set; }//Use_Id
        public int Rol_Id { get; set; }//Rol_Id
        public int UserId { get; set; }//用户Id
        public int Rid { get; set; }//角色Id
    }
}
