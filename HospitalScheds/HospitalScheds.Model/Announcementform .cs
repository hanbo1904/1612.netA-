using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HospitalScheds.Model
{
    /// <summary>
    /// 消息公布
    /// </summary>
  public   class Attendancestatisticslist
    {
        [Key]
        /// <summary>
        /// 主键ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 发布内容
        /// </summary>
        public string releasecontent { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int status { get; set; }

        /// <summary>
        /// 发布人员
        /// </summary>
        public string releasepeople { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime releasetime { get; set; } 

        /// <summary>
        /// 读取状态
        /// </summary>
        public int readstatus { get; set; }
    }
}
