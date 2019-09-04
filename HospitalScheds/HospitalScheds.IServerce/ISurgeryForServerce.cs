using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;

namespace HospitalScheds.IServerce
{
    /// <summary>
    /// 手术申请表
    /// </summary>
    public interface ISurgeryForServerce
    {
            /// <summary>
            /// 显示
            /// </summary>
            /// <returns></returns>
            PageModel<SurgeryFor> GetSurgeryFor(int pageIndex=1,int pageSize=3);

            /// <summary>
            /// 添加
            /// </summary>
            /// <param name="crewscheduling"></param>
            /// <returns></returns>
            int AddSurgeryFor(SurgeryFor surgeryFor);

            /// <summary>
            /// 修改
            /// </summary>
            /// <param name="crewscheduling"></param>
            /// <returns></returns>
            int EditSurgeryFor(SurgeryFor surgeryFor);

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        SurgeryFor GetModel(int id);

            /// <summary>
            /// 删除
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            int DeleteSurgeryFor(int id);
        }
}
