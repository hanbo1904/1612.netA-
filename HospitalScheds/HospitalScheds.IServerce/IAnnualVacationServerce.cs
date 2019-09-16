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
        List<AnnualVacation> GetAnnualVacation();
    }
}
