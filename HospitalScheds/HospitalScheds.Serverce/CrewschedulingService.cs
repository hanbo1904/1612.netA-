using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;
using HospitalScheds.IServerce;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HospitalScheds.Serverce
{
    public class CrewschedulingService : ICrewschedulingServerce
    {

        DataContext db = new DataContext();

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="crewscheduling"></param>
        /// <returns></returns>
        public int AddCrewscheduling(Crewscheduling crewscheduling)
        {
            db.Crewschedulinglist.Add(crewscheduling);
            int i = db.SaveChanges();
            return i;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteCrewscheduling(int id)
        {
            var list = db.Crewschedulinglist.Find(id);
            db.Crewschedulinglist.Remove(list);
            int i = db.SaveChanges();
            return i;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="crewscheduling"></param>
        /// <returns></returns>
        public int EditCrewscheduling(Crewscheduling crewscheduling)
        {
            db.Entry(crewscheduling).State = EntityState.Modified;
            int i = db.SaveChanges();
            return i;
        }

        /// <summary>
        /// 显示分页
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="CrewsName"></param>
        /// <returns></returns>
        //public PageModel<Crewscheduling> GetCrewscheduling(int pageIndex = 1, int pageSize = 3,string CrewsName="")
        //{
        //    if (CrewsName == null)
        //    {
        //        CrewsName = "";
        //    }
        //    PageModel<Crewscheduling> pagemodel = new PageModel<Crewscheduling>();
        //    int totalcount = db.Crewschedulinglist.Where(m => m.CrewsName.Contains(CrewsName)).ToList().Count();
        //    //分页
        //    var list = db.Crewschedulinglist.Where(m => m.CrewsName.Contains(CrewsName)).ToList().Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        //    pagemodel.TotalCount = totalcount;
        //    pagemodel.Data = list;
        //    return pagemodel;
        //}

        public List<Crewscheduling> GetCrewschedulings()
        {

            var list = db.Crewscheduling.ToList();
            return list;
        }

            /// <summary>
            /// 反填
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            public Crewscheduling GetModel(int id)
        {
            var lsit = db.Crewschedulinglist.Find(id);
            return lsit;
        }
    }
}
