using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    /// <summary>
    /// Permission 权限表
    /// </summary>
    public class Permission : BaseEntity
    {
        public int Id { get; set; }//id
        public string Pname { get; set; }//权限名称
        public string Url { get; set; }//链接地址
        public int Pid { get; set; }//父级id
        public int Remark { get; set; }//描述
        public int SortId { get; set; }//排序
        public string CreatePerson { get; set; }//添加人
        public DateTime CreateTime { get; set; }//添加时间
        public string IsUse { get; set; }//是否启用
    }
}
