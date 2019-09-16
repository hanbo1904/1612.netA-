using HospitalScheds.Model;
using System;
using System.Collections.Generic;
using System.Text;
using HospitalScheds.IServerce;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HospitalScheds.Serverce
{
    /// <summary>
    /// 专业分组设置
    /// </summary>
    public class MajorgroupServerce: IMajorgroupServerce
    {
        DataContext db = new DataContext();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="majorgrouping"></param>
        /// <returns></returns>
        public int Add(Majorgrouping majorgrouping)
        {
            db.Majorgroupinglist.Add(majorgrouping);
            int i = db.SaveChanges();
            return i;
        }


        /// <summary>
        /// 显示分页
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Majorgrouping> GetMajor()
        {

            var list = db.Majorgroupinglist.ToList();
            return list;

            //List<Announcementform> totalcount =db.Announcementform.Where(n => n.releasecontent.Contains(Name)).ToList();
            //return totalcount;

            //if (Name == null)
            //{
            //    Name = "";
            //}
            //// List<Announcementform> pagemodel = new List<Announcementform>();
            //List<Announcementform> totalcount = new List<Announcementform>(db.Announcementform.Where(m => m.releasecontent.Contains(Name)).ToList().Count()); 
            ////分页
            ////var list = db.Announcementform.Where(m => m.releasecontent.Contains(Name)).ToList().Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            ////pagemodel.TotalCount = totalcount;
            ////pagemodel.Data = list;
            //return totalcount;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int ids)
        {
            var list = db.Majorgroupinglist.Find(ids);
            db.Majorgroupinglist.Remove(list);
            int i = db.SaveChanges();
            return i;
        }
        /// <summary>
        ///  修改
        /// </summary>
        /// <param name="majorgrouping"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Update(Majorgrouping majorgrouping, int id)
        {
            db.Entry(majorgrouping).State = EntityState.Modified;
            int i = db.SaveChanges();
            return i;
        }
    }
}
