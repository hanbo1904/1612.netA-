using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;

namespace HospitalScheds.IServerce
{
    /// <summary>
    /// 接龙设置表
    /// </summary>
    public interface IShiftRulesServerce
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        PageModel<ShiftRules> GetShiftRules(int pageIndex = 1, int pageSize = 3);

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="crewscheduling"></param>
        /// <returns></returns>
        int AddShiftRules(ShiftRules shiftRules);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="crewscheduling"></param>
        /// <returns></returns>
        int EditShiftRules(ShiftRules shiftRules);

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ShiftRules GetModel(int id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteShiftRules(int id);
    }
}
