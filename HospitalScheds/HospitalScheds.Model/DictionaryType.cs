using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    /// <summary>
    /// 字典表
    /// </summary>
   public class DictionaryType : BaseEntity
    {
        public int Id { get; set; }//Id
        public int Did { get; set; }//Did
        public string Detaile { get; set; }//详情
    }
}
