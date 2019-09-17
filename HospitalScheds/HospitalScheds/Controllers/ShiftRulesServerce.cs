using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HospitalScheds.Model;
using HospitalScheds.IServerce;


namespace HospitalScheds.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShiftRulesServerce : ControllerBase
    {
        /// <summary>
        /// 定义私有变量
        /// </summary>
        private IShiftRulesServerce _shiftRulesServerce;
        public ShiftRulesServerce(IShiftRulesServerce shiftRulesServerce)
        {
            _shiftRulesServerce = shiftRulesServerce;
        }
        [HttpPost]
        public int Add(ShiftRules schedulingRules)
        {
            int i = _shiftRulesServerce.Add(schedulingRules);
            return i;
        }
        [HttpGet]
        public List<ShiftRules> Index()
        {
            var list = _shiftRulesServerce.GetShiftRules();
            return list;
        }
        [HttpDelete]
        public int Delete(int id)
        {
            int i = _shiftRulesServerce.DeleteShiftRules(id); 
            return i;
        }
        [HttpPut]
        public int Update(ShiftRules shiftRules, int id)
        {
            int i = _shiftRulesServerce.Update(shiftRules, id);
            return i;
        }
    }
}