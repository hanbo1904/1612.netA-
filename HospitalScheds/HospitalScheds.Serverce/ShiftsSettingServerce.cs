using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HospitalScheds.IServerce;
using HospitalScheds.Model;
using Microsoft.EntityFrameworkCore;
namespace HospitalScheds.Serverce
{
    public class ShiftsSettingServerce 
    {
        DataContext db = new DataContext();

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="shiftsSetting"></param>
        /// <returns></returns>
        public int Add(ShiftsSetting shiftsSetting)
        {
            db.ShiftsSettinglist.Add(shiftsSetting);
            int i = db.SaveChanges();
            return i;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int DelShiftsSetting(int Id)
        {
            var list = db.ShiftsSettinglist.Find(Id);
            db.ShiftsSettinglist.Remove(list);
            int i = db.SaveChanges();
            return i;
        }

        /// <summary>
        /// 返填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public ShiftsSetting GetShiftsSetting(int Id)
        {
            var lsit = db.ShiftsSettinglist.Find(Id);
            return lsit;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="shiftsSetting"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int GetShiftsSetting(ShiftsSetting shiftsSetting, int Id)
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
        public PageModel<ShiftsSetting> GetShiftsSetting(string Name = "", int pageIndex = 1, int pageSize = 3)
        {
            if (Name == null)
            {
                Name = "";
            }
            PageModel<ShiftsSetting> pagemodel = new PageModel<ShiftsSetting>();
            int totalcount = db.ShiftsSettinglist.Where(m => m.Name.Contains(Name)).ToList().Count();
            //分页
            var list = db.ShiftsSettinglist.Where(m => m.Name.Contains(Name)).ToList().Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            pagemodel.TotalCount = totalcount;
            pagemodel.Data = list;
            return pagemodel;
        }
    }
}
