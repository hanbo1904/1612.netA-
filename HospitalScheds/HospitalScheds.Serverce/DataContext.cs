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
        /// <summary>
        /// 用户表
        /// </summary>
        public DbSet<UserInfo> UserInfolist { get; set; }


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
        /// 班次工时统计
        /// </summary>
        public DbSet<Shifthoursstatistics> Shifthoursstatisticslist { get; set; }


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
