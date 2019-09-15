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
    /// <summary>
    /// 专业分组设置
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MajorgroupController : ControllerBase
    {
        private IMajorgroupServerce _majorgroupServerce;
        public MajorgroupController(IMajorgroupServerce majorgroupServerce)
        {
            _majorgroupServerce = majorgroupServerce;
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="majorgrouping"></param>
        /// <returns></returns>
        [HttpPost]
        public int Add(Majorgrouping majorgrouping)
        {
            int i = _majorgroupServerce.Add(majorgrouping);
            return i;
        }
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Majorgrouping> GetMajor()
        {
            var list = _majorgroupServerce.GetMajor();
            return list;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        [HttpDelete]
        public int Delete(int ids)
        {
            int i = _majorgroupServerce.Delete(ids);
            return i;
        }
    }
}