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
        /// 人员排班
        /// </summary>
        public DbSet<Crewscheduling> Crewscheduling { get; set; }
   

        /// <summary>
        /// 部门表
        /// </summary>
        public DbSet<Department> Departmentlist { get; set; }
        /// <summary>
        /// 字典表
        /// </summary>
        public DbSet<DictionaryType> DictionaryTypelist { get; set; }
        /// <summary>
        /// 登录表
        /// </summary>
        public DbSet<Login> Loginlist { get; set; }
        /// <summary>
        /// 专业分组设置
        /// </summary>
        public DbSet<Majorgrouping> Majorgroupinglist { get; set; }
        /// <summary>
        /// 早班人员列表
        /// </summary>
        public DbSet<MorningShift> MorningShiftlist { get; set; }
        /// <summary>
        /// 手术排班
        /// </summary>
        public DbSet<operation> operationlist { get; set; }
        /// <summary>
        /// 权限表
        /// </summary>
        public DbSet<Permission> Permissionllist { get; set; }
        /// <summary>
        /// 角色权限关联表
        /// </summary>
        public DbSet<PermissionRole> PermissionRolelist { get; set; }
        /// <summary>
        /// 审批流程配置表
        /// </summary>
        public DbSet<ProcessConfiguration> ProcessConfigurationlist { get; set; }
        /// <summary>
        /// 角色表
        /// </summary>
        public DbSet<Role> Rolelist { get; set; }
        /// <summary>
        ///  手术排班(护士)
        /// </summary>
        public DbSet<Schedulingmodel> Schedulingmodellist { get; set; }

        /// <summary>
        /// 假期申请
        /// </summary>
        public DbSet<Vacation> Vacationlist { get; set; }
        /// <summary>
        /// 角色权限关联表
        /// </summary>
        public DbSet<UserRole> UserRolelist { get; set; }
        /// <summary>
        /// 手术申请表
        /// </summary>
        public DbSet<SurgeryFor> SurgeryForlist { get; set; }
        /// <summary>
        /// 连休
        /// </summary>
        public DbSet<Straight> Straightlist { get; set; }
        /// <summary>
        /// 法定节日
        /// </summary>
        public DbSet<Statutoryholiday> Statutoryholidaylist { get; set; }
        /// <summary>
        /// 特殊工时
        /// </summary>
        public DbSet<Specialworkinghours> Specialworkinghourslist { get; set; }
        /// <summary>
        /// 排班规则设置表
        /// </summary>
        public DbSet<SchedulingRules> SchedulingRuleslist { get; set; }
        /// <summary>
        /// 接龙设置表
        /// </summary>
        public DbSet<SolitaireSet> SolitaireSetlist { get; set; }
        /// <summary>
        /// 班次设置表
        /// </summary>
        public DbSet<ShiftsSetting> ShiftsSettinglist { get; set; }
        /// <summary>
        /// 班次规则表
        /// </summary>
        public DbSet<ShiftRules> ShiftRuleslist { get; set; }
        /// <summary>
        /// 人员排班
        /// </summary>
        public DbSet<Crewscheduling> Crewschedulinglist { get; set; }
        /// <summary>
        /// 班次工时统计
        /// </summary>
        public DbSet<Shifthoursstatistics> Shifthoursstatisticslist { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // if (!optionsBuilder.IsConfigured)
            // {
            //     optionsBuilder.UseMySQL("Data Source=169.254.139.102;Initial Catalog=hospital;User ID=hanbo;pwd=123456");
            // }
            //else
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Data Source=10.31.54.14;Initial Catalog=hospital;User ID=hanbo;pwd=123456");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
