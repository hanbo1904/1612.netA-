using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;

namespace HospitalScheds.IServerce
{
    /// <summary>
    /// 排班表
    /// </summary>
    public interface IShiftRulesServerce
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        List<ShiftRules> GetShiftRules(string Name = "");

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="crewscheduling"></param>
        /// <returns></returns>
        int Add(ShiftRules shiftRules);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="crewscheduling"></param>
        /// <returns></returns>
        int Update(ShiftRules shiftRules,int Id);

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ShiftRules GetShiftRules(int id);


        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteShiftRules(int id);

    }
}
