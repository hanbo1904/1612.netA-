using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;

namespace HospitalScheds.IServerce
{
    /// <summary>
    /// 早班人员列表
    /// </summary>
    public interface IMorningShiftServerce
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        List<MorningShift> GetMorningShift();

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="crewscheduling"></param>
        /// <returns></returns>
        int AddMorningShift(MorningShift morningShift);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="crewscheduling"></param>
        /// <returns></returns>
        int EditMorningShift(MorningShift morningShift);

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        MorningShift GetModel(int id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteMorningShift(int id);
    }
}
