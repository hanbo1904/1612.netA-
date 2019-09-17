using System;
using System.Collections.Generic;
using System.Text;



using HospitalScheds.Model;
using HospitalScheds.IServerce;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HospitalScheds.Serverce
{
    public class ShiftRulesServerce : IShiftRulesServerce   
    {
        DataContext db = new DataContext();
        
        public List<ShiftRules> GetShiftRules(string Name = "")
        {
            var list = db.ShiftRules.ToList();
            return list;
        }

        public int Update(ShiftRules shiftRules, int Id)
        {
            db.Entry(shiftRules).State = EntityState.Modified;
            int i = db.SaveChanges();
            return i;
        }

        public ShiftRules GetShiftRules(int id)
        {
            var list = db.ShiftRules.Find(id);
            return list;
        }

        public int DeleteShiftRules(int id)
        {
            var list = db.ShiftRules.Find(id);
            db.ShiftRules.Remove(list);
            int i = db.SaveChanges();
            return i;
        }

        public int Add(ShiftRules shiftRules)
        {
            db.ShiftRules.Add(shiftRules);
            int i = db.SaveChanges();
            return i;
        }
    }
}
