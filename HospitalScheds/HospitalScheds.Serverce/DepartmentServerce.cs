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
    public class DepartmentServerce : IDepartment
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        public int Add(IDepartment department)
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
        public List<IDepartment> GetDepartment(string Name = "")
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public IDepartment GetDepartment(int Id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="department"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int GetDepartment(IDepartment department, int Id)
        {
            throw new NotImplementedException();
        }
    }
}
