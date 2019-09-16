using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HospitalScheds.IServerce;
using HospitalScheds.Model;
using Microsoft.EntityFrameworkCore;
namespace HospitalScheds.Serverce
{
    public class ShiftsSettingServerce : IShiftsSettingServerce
    {
        DataContext db = new DataContext();

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="shiftsSetting"></param>
        /// <returns></returns>
        public int Add(ShiftsSetting shiftsSetting)
        {
            db.ShiftsSetting.Add(shiftsSetting);
            int i = db.SaveChanges();
            return i;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int DelShiftsSetting(int ids)
        {
            var list = db.ShiftsSetting.Find(ids);
            db.ShiftsSetting.Remove(list);
            int i = db.SaveChanges();
            return i;
        }

        ///// <summary>
        ///// 返填
        ///// </summary>
        ///// <param name="Id"></param>
        ///// <returns></returns>
        //public ShiftsSetting GetShiftsSetting(int Id)
        //{
        //    var lsit = db.ShiftsSettinglist.Find(Id);
        //    return lsit;
        //}

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="shiftsSetting"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int UptShiftsSetting(ShiftsSetting shiftsSetting, int Id)
        {
            db.Entry(shiftsSetting).State = EntityState.Modified;
            int i = db.SaveChanges();
            return i;
        }

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<ShiftsSetting> GetShiftsSetting()
        {
            var list = db.ShiftsSetting.ToList();
            return list;
          //  if (Name == null)
            {
               // Name = "";
            }
          //  PageModel<ShiftsSetting> pagemodel = new PageModel<ShiftsSetting>();
           // int totalcount = db.ShiftsSettinglist.Where(m => m.Name.Contains(Name)).ToList().Count();
            //分页
           // var list = db.ShiftsSettinglist.Where(m => m.Name.Contains(Name)).ToList().Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            //pagemodel.TotalCount = totalcount;
           // pagemodel.Data = list;
            //return pagemodel;
        }

        public ShiftsSetting PShiftsSetting(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
