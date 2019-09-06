using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;

namespace HospitalScheds.IServerce
{
    /// <summary>
    ///人员排班
    /// </summary>
    public interface ICrewschedulingServerce
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        PageModel<Crewscheduling> GetCrewscheduling(int pageIndex = 1, int pageSize = 3);
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="crewscheduling"></param>
        /// <returns></returns>
        int AddCrewscheduling(Crewscheduling crewscheduling);
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="crewscheduling"></param>
        /// <returns></returns>
        int EditCrewscheduling(Crewscheduling crewscheduling);
        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Crewscheduling GetModel(int id);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteCrewscheduling(int id);
    }
}
