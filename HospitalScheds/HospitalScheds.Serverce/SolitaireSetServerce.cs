using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HospitalScheds.IServerce;
using HospitalScheds.Model;
using Microsoft.EntityFrameworkCore;

namespace HospitalScheds.Serverce
{
    public class SolitaireSetServerce : ISolitaireSetServerce
    {
       
        DataContext db = new DataContext();

        public PageModel<SolitaireSet> GetSolitaireSet(string Name = "", int pageIndex = 0,int pageSize = 3)
        {
            if (Name == null)
            {
                Name = "";
            }
            PageModel<SolitaireSet> pagemodel = new PageModel<SolitaireSet>();
            int totalcount = db.SolitaireSetlist.Where(m => m.SolitaireShifts.Contains(Name)).ToList().Count();
            //分页
            var list = db.SolitaireSetlist.Where(m => m.SolitaireShifts.Contains(Name)).ToList().Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            pagemodel.TotalCount = totalcount;
            pagemodel.Data = list;
            return pagemodel;
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="solitaireSet"></param>
        /// <returns></returns>
        public int Add(SolitaireSet solitaireSet)
        {
            db.SolitaireSetlist.Add(solitaireSet);
            int i = db.SaveChanges();
            return i;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int DelSolitaire(int Id)
        {
            var list = db.SolitaireSetlist.Find(Id);
            db.SolitaireSetlist.Remove(list);
            int i = db.SaveChanges();
            return i;
        }
        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public SolitaireSet GetSolitaireSet(int Id)
        {
            var lsit = db.SolitaireSetlist.Find(Id);
            return lsit;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="solitaireSet"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int GetSolitaireSet(SolitaireSet solitaireSet, int Id)
        {
            db.Entry(solitaireSet).State = EntityState.Modified;
            int i = db.SaveChanges();
            return i;
        }

    }
}
