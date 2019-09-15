using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HospitalScheds.IServerce;
using HospitalScheds.Model;
using Microsoft.EntityFrameworkCore;

namespace HospitalScheds.Serverce
{
    //public class VacationServerce : IVacationServerce
    //{
    //    DataContext db = new DataContext();

    //    /// <summary>
    //    /// 添加
    //    /// </summary>
    //    /// <param name="vacation"></param>
    //    /// <returns></returns>
    //    public int AddVacation(Vacation vacation)
    //    {
    //        db.Vacationlist.Add(vacation);
    //        int i = db.SaveChanges();
    //        return i;
    //    }

    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <param name="id"></param>
    //    /// <returns></returns>
    //    public int DeleteVacation(int id)
    //    {
    //        var list = db.Vacationlist.Find(id);
    //        db.Vacationlist.Remove(list);
    //        int i = db.SaveChanges();
    //        return i;
    //    }

    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <param name="vacation"></param>
    //    /// <returns></returns>
    //    public int EditVacation(Vacation vacation)
    //    {
    //        db.Entry(vacation).State = EntityState.Modified;
    //        int i = db.SaveChanges();
    //        return i;
    //    }

    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <param name="id"></param>
    //    /// <returns></returns>
    //    public Vacation GetModel(int id)
    //    {
    //        var lsit = db.Vacationlist.Find(id);
    //        return lsit;
    //    }

    //    /// <summary>
    //    /// 显示
    //    /// </summary>
    //    /// <param name="pageIndex"></param>
    //    /// <param name="pageSize"></param>
    //    /// <returns></returns>
    //    public PageModel<Vacation> GetVacation( int pageIndex = 1, int pageSize = 3)
    //    {
    //        PageModel<Vacation> pagemodel = new PageModel<Vacation>();
    //        int totalcount = db.Vacationlist.Where(m => m.Contains("")).ToList().Count();
    //        //分页
    //        var list = db.Vacationlist.Where(m => m.Contains("")).ToList().Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
    //        pagemodel.TotalCount = totalcount;
    //        pagemodel.Data = list;
    //        return pagemodel;
    //    }
    //}
}
