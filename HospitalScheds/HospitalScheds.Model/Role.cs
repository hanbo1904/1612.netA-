using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    /// <summary>
    /// RoleInfo 角色表
    /// </summary>
    public class Role : BaseEntity
    {
        public int Id { get; set; }//Id
        public string Rname { get; set; }//角色名称
        public string Pname { get; set; }//权限名称
        public int IsUse { get; set; }//状态
        public int Did { get; set; }//部门ID
        public string CreatePerson { get; set; }//创建人
        public DateTime CreateTime { get; set; }//创建时间
    }
}
