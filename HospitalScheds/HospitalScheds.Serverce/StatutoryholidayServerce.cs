using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;
using HospitalScheds.IServerce;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HospitalScheds.Serverce
{
    public class StatutoryholidayServerce : IStatutoryholidayServerce
    {
        DataContext db = new DataContext();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="statutoryholiday"></param>
        /// <returns></returns>
        public int AddStatutoryholiday(Statutoryholiday statutoryholiday)
        {
           
            
            db.Statutoryholidaylist.Add(statutoryholiday);
            int i = db.SaveChanges();
            return i;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public int DeleteStatutoryholiday(int id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="statutoryholiday"></param>
        /// <returns></returns>

        public int EditStatutoryholiday(Statutoryholiday statutoryholiday)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Statutoryholiday GetModel(int id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public PageModel<Statutoryholiday> GetStatutoryholiday(string Name = "",int pageIndex = 1, int pageSize = 3)
        {
            if (Name == null)
            {
                Name = "";
            }
            PageModel<Statutoryholiday> pagemodel = new PageModel<Statutoryholiday>();
            int totalcount = db.Statutoryholidaylist.Where(m => m.Holiday.Contains(Name)).ToList().Count();
            //分页
            var list = db.Statutoryholidaylist.Where(m => m.Holiday.Contains(Name)).ToList().Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            pagemodel.TotalCount = totalcount;
            pagemodel.Data = list;
            return pagemodel;
        }
    }
}
