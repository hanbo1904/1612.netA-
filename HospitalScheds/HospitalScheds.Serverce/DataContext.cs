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
