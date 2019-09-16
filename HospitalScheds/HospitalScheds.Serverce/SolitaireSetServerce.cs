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

        public List<SolitaireSet> GetSolitaireSet()
        {
            List<SolitaireSet> list = db.SolitaireSet.ToList();
            return list;
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="solitaireSet"></param>
        /// <returns></returns>
        public int Add(SolitaireSet solitaireSet)
        {
            db.SolitaireSet.Add(solitaireSet);
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
            var list = db.SolitaireSet.Find(Id);
            db.SolitaireSet.Remove(list);
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
            var lsit = db.SolitaireSet.Find(Id);
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
