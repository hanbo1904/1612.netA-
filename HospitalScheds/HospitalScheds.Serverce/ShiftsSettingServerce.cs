using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.IServerce;
using HospitalScheds.Model;
namespace HospitalScheds.Serverce
{
    public class ShiftsSettingServerce : IShiftsSettingServerce
    {
        public int Add(ShiftsSetting shiftsSetting)
        {
            throw new NotImplementedException();
        }

        public int DelShiftsSetting(int Id)
        {
            throw new NotImplementedException();
        }

        public ShiftsSetting GetShiftsSetting(int Id)
        {
            throw new NotImplementedException();
        }

        public int GetShiftsSetting(ShiftsSetting shiftsSetting, int Id)
        {
            throw new NotImplementedException();
        }

        PageModel<ShiftsSetting> IShiftsSettingServerce.GetShiftsSetting(string Name, int pageIndex, int pageSize)
        {
            PageModel<ShiftsSetting> pageModel = new PageModel<ShiftsSetting>();
            StringBuilder sql = new StringBuilder();
            StringBuilder countsql = new StringBuilder();

            sql.Append(@"select * from(
            select ROW_NUMBER() over(order by a.Id) rownum, a.*,b.Name as ConName,d.Name as TypeName  from LaborContract a join Dictionaries b on a.ContranctType=b.Id join Dictionaries d 
              on a.ContractStatus=d.Id  where 1 = 1 ");

            countsql.Append(@"select count(1) from ShiftsSetting where 1=1 ");

            if (!string.IsNullOrWhiteSpace(ContractName))
            {
                sql.Append($" and ContractName like '%{ContractName}%'");
                countsql.Append($" and ContractName like '%{ContractName}%'");
            }
        }
    }
}
