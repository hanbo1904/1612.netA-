using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;

namespace HospitalScheds.IServerce
{
    /// <summary>
    /// 手术排班(护士)
    /// </summary>
    public interface ISchedulingmodelServerce
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        List<Schedulingmodel> GetSchedulingmodel();

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="crewscheduling"></param>
        /// <returns></returns>
        int AddSchedulingmodel(Schedulingmodel schedulingmodel);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="crewscheduling"></param>
        /// <returns></returns>
        int EditSchedulingmodel(Schedulingmodel schedulingmodel);

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Schedulingmodel GetModel(int id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteSchedulingmodel(int id);
    }
}
