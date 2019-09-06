using System;
using System.Collections.Generic;

namespace HospitalScheds.Model
{
    public class PageModel<T> 
    {
        /// <summary>
        /// 分页数据集
        /// </summary>
        public List<T> Data { get; set; }
        /// <summary>
        /// 总记录数
        /// </summary>
        public int TotalCount { get; set; }
    }
}
