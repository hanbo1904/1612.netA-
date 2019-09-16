using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HospitalScheds.IServerce;
using HospitalScheds.Model;
namespace HospitalScheds.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShiftsSettingController : ControllerBase
    {
        /// <summary>
        /// 定义私有变量
        /// </summary>
        private IShiftsSettingServerce _shiftsSettingServerce;

        /// <summary>
        /// 构造函数注入
        /// </summary>
        /// <param name="organization"></param>
        public ShiftsSettingController(IShiftsSettingServerce shiftsSettingServerce)
        {
            _shiftsSettingServerce = shiftsSettingServerce;
        }


        /// <summary>
        /// 显示分页
        /// </summary>
        /// <param name="announcementform"></param> 
        /// <returns></returns>
        [HttpGet]
        public List<ShiftsSetting> Indexs()
        {
            var list = _shiftsSettingServerce.GetShiftsSetting();
            return list;
        }


        [HttpPost]
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="announcementform"></param>
        /// <returns></returns>

        public int Add(ShiftsSetting shiftsSetting)
        {
            int i = _shiftsSettingServerce.Add(shiftsSetting);
            return i;
        }

        

        //[HttpPut]
        ///// <summary>
        ///// 修改
        ///// </summary>
        ///// <param name="announcementform"></param>
        ///// <returns></returns> 
        //[HttpPost]
        //public int Update(ShiftsSetting shiftsSetting, int id)
        //{
        //    int i = _shiftsSettingServerce.GetShiftsSetting(shiftsSetting, id);
        //    return i;
        //}

        [HttpDelete]
        /// <summary>
        ///删除
        /// </summary>
        /// <param name="announcementform"></param>
        /// <returns></returns> 
        [HttpPost]
        public int Delete(int id)
        {
            int i = _shiftsSettingServerce.DelShiftsSetting(id);
            return i;
        }
    }
}