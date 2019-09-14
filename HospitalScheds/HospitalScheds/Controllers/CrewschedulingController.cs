using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using HospitalScheds.Model;
using HospitalScheds.IServerce;
using HospitalScheds.Serverce;

namespace HospitalScheds.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrewschedulingController : ControllerBase
    {

        /// <summary>
        /// 定义私有变量
        /// </summary>
        private ICrewschedulingServerce _crewschedulingServerce;


        /// <summary>
        /// 构造函数注入
        /// </summary>
        /// <param name="organization"></param>
        public CrewschedulingController(ICrewschedulingServerce crewschedulingServerce)
        {
            _crewschedulingServerce = crewschedulingServerce;
        }

        [HttpGet]
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Crewscheduling> Indexs()
        {
            var list = _crewschedulingServerce.GetCrewscheduling();
            return list;
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="crewscheduling"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddCrewscheduling(Crewscheduling crewscheduling)
        {
            int i = _crewschedulingServerce.AddCrewscheduling(crewscheduling);
            return i;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="crewscheduling"></param>
        /// <returns></returns>
        [HttpPut]
        int EditCrewscheduling(Crewscheduling crewscheduling)
        {
            int i = _crewschedulingServerce.EditCrewscheduling(crewscheduling);
            return i;
        }

        [HttpGet]
        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Crewscheduling GetModel(int id)
        {
            Crewscheduling crewscheduling = _crewschedulingServerce.GetModel(id);
            return crewscheduling;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        int DeleteCrewscheduling(int id)
        {
            int i = _crewschedulingServerce.DeleteCrewscheduling(id);
            return i;
        }
    }
}