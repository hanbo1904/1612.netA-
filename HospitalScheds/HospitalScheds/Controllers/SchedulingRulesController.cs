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
    public class SchedulingRulesController : ControllerBase
    {
        /// <summary>
        /// 定义私有变量
        /// </summary>
        private ISchedulingRulesServerce _schedulingRulesServerce;
        public SchedulingRulesController(ISchedulingRulesServerce schedulingRulesServerce)
        {
            _schedulingRulesServerce = schedulingRulesServerce;
        }
        [HttpPost]
        public int Add(SchedulingRules schedulingRules)
        {
            int i = _schedulingRulesServerce.Add(schedulingRules);
            return i;
        }
        [HttpGet]
        public List<SchedulingRules> Indexs()
        {
            var list = _schedulingRulesServerce.GetSchedulingRules();
            return list;
        }
        [HttpDelete]
        public int Delete(int id)
        {
            int i = _schedulingRulesServerce.DelSchedulingRules(id);
            return i;
        }
        [HttpPut]
        public int Update(SchedulingRules schedulingRules, int id)
        {
            int i = _schedulingRulesServerce.Update(SchedulingRules, id);
            return i;
        }
    }
}