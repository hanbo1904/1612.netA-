using System;
using System.Collections.Generic;
using System.Text;


using HospitalScheds.Model;
using HospitalScheds.IServerce;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HospitalScheds.Serverce
{
    public class SchedulingRulesServerce : ISchedulingRulesServerce
    {
        DataContext db = new DataContext();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="schedulingRules"></param>
        /// <returns></returns>
        public int Add(SchedulingRules schedulingRules)
        {
            db.SchedulingRuleslist.Add(schedulingRules);
            int i = db.SaveChanges();
            return i;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int DelSchedulingRules(int Id)
        {
            var list = db.SchedulingRuleslist.Find(Id);
            db.SchedulingRuleslist.Remove(list);
            int i = db.SaveChanges();
            return i;
        }
        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public SchedulingRules GetSchedulingRules(int Id)
        {
            var list = db.SchedulingRuleslist.Find(Id);
            return list;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="schedulingRules"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int Update(SchedulingRules schedulingRules, int Id)
        {
            db.Entry(schedulingRules).State = EntityState.Modified;
            int i = db.SaveChanges();
            return i;
        }

        public List<SchedulingRules> GetSchedulingRules(string Name = "")
        {
            throw new NotImplementedException();
        }





        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<SchedulingRules> schedulingRules()
        {
            //var list = db.SchedulingRuleslist.Find();
            var list = db.SchedulingRuleslist.ToList();
            return list;
            //    var list = db.SchedulingRuleslist.Find();
            //    return list;

        }

       
    }
}
