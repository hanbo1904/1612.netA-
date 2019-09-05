using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using HospitalScheds.Model;

namespace HospitalScheds.IServerce
{
    /// <summary>
    /// 部门表
    /// </summary>
    public interface IDepartmentServerce
    {

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        int Add(IDepartmentServerce department);

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        List<IDepartmentServerce> GetDepartment(string Name = "");

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        IDepartmentServerce GetDepartment(int Id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="department"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        int GetDepartment(IDepartmentServerce department, int Id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DelDepartment(int Id);

    }
}
