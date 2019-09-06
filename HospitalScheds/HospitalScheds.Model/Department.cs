using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    /// <summary>
    /// 部门表
    /// </summary>
   public class Department 
    {
        public int Id { get; set; }//Id
        public string Name { get; set; }//部门名称
        public int Pid { get; set; }//父级Id
    }
}
