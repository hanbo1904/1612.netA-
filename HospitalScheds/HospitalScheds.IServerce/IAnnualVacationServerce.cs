using HospitalScheds.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.IServerce
{
    /// <summary>
    /// 年假申请设置
    /// </summary>
    public interface IAnnualVacationServerce
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="approval"></param>
        /// <returns></returns>
        int Add(AnnualVacation annualVacation);

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        List<AnnualVacation> GetAnnualVacation(string Name = "");

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        AnnualVacation GetAnnualVacation(int Id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="approval"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        int GetAnnualVacation(AnnualVacation annualVacation, int Id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DelAnnualVacation(int Id);
    }
}
