using System;
using System.Collections.Generic;
using System.Text;
using HospitalScheds.Model;
using HospitalScheds.IServerce;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HospitalScheds.Serverce
{
    public class AnnouncementformServerce:IAnnouncementformServerce
    {
        DataContext db = new DataContext();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="announcementform"></param>
        /// <returns></returns>
        public int Add(Announcementform announcementform)
        {
            db.Announcementform.Add(announcementform);
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
        public List<Announcementform> GetAnnount()
        {

            var list = db.Announcementform.ToList();
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
       // [Route("api/[controller]")]
      //  [ApiController]

        /// <summary>
        /// 反填
        /// </summary>
        /// <returns></returns>
        public Announcementform Byid(int id)
        {
            var lsit = db.Announcementform.Find(id);
            return lsit;
        }


        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int ids)
        {
            var list = db.Announcementform.Find(ids);
            db.Announcementform.Remove(list);
            int i = db.SaveChanges();
            return i;
        }


        /// <summary>
        ///  修改
        /// </summary>
        /// <param name="announcementform"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Update(Announcementform announcementform,int id)
        {
            db.Entry(announcementform).State = EntityState.Modified;
            int i = db.SaveChanges();
            return i;
        }
    }
}
