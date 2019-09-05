using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;
using HospitalScheds.IServerce;

namespace HospitalScheds.Serverce
{
    /// <summary>
    /// 部门表
    /// </summary>
    public class DepartmentServerce : IDepartmentServerce
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        public int Add(IDepartmentServerce department)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int DelDepartment(int Id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public List<IDepartmentServerce> GetDepartment(string Name = "")
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public IDepartmentServerce GetDepartment(int Id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="department"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int GetDepartment(IDepartmentServerce department, int Id)
        {
            throw new NotImplementedException();
        }
    }
}
