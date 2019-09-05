using HospitalScheds.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Serverce
{
    public class DataContext: DbContext
    {
        public DataContext()
        {

        }
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<UserInfo> UserInfolist { get; set; }

        /// <summary>
        /// 消息公布
        /// </summary>
        public DbSet<Announcementform> Announcementform { get; set; }

        /// <summary>
        /// 年假申请设置
        /// </summary>
        public DbSet<AnnualVacation> AnnualVacation { get; set; }

        /// <summary>
        /// 审批表
        /// </summary>
        public DbSet<Approval> Approval { get; set; }

        /// <summary>
        /// 审批活动表
        /// </summary>
        public DbSet<Approvalactivity> Approvalactivity { get; set; }

        /// <summary>
        /// 审批条件
        /// </summary>
        public DbSet<ApprovalCriteria> ApprovalCriteria { get; set; }

        /// <summary>
        /// 考勤统计
        /// </summary>
        public DbSet<Attendance> Attendance { get; set; }

        /// <summary>
        /// 考勤统计明细表
        /// </summary>
        public DbSet<Attendancestatisticslist> Attendancestatisticslist { get; set; }

        /// <summary>
        /// 考勤统计汇总
        /// </summary>
        public DbSet<Attendancestatisticssummary> Attendancestatisticssummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<BaseEntity> BaseEntity { get; set; }

        /// <summary>
        /// 人员排班
        /// </summary>
        public DbSet<Crewscheduling> Crewscheduling { get; set; }
   





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Data Source=127.0.0.1;Initial Catalog=projectmanage;User ID=root;pwd=123456");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
