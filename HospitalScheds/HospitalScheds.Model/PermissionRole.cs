using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    /// <summary>
    /// 角色权限关联表
    /// </summary>
    public class PermissionRole 
    {
        public int Id { get; set; }//
        public int Rol_Id { get; set; }//Rol_Id
        public int Per_Id { get; set; }//Per_Id
        public int Rid { get; set; }//角色Id
        public int Pid { get; set; }//权限Id
    }
}
