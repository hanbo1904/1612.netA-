using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;
using HospitalScheds.IServerce;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HospitalScheds.Serverce
{
    public class AnnualVacationService : IAnnualVacationServerce
    {
        DataContext db = new DataContext();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="annualVacation"></param>
        /// <returns></returns>
        public int Add(AnnualVacation annualVacation)
        {
            db.AnnualVacation.Add(annualVacation);
            int i = db.SaveChanges();
            return i;
        }
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<AnnualVacation> GetAnnualVacation()
        {
            var list = db.AnnualVacation.ToList();
            return list;
        }
    }
}
