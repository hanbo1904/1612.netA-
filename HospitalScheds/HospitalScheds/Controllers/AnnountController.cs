﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalScheds.IServerce;
using HospitalScheds.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalScheds.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnountController : ControllerBase
    {

        /// <summary>
        /// 定义私有变量
        /// </summary>
        private IAnnouncementformServerce _announcementformServerce;


        /// <summary>
        /// 构造函数注入
        /// </summary>
        /// <param name="organization"></param>
        public AnnountController(IAnnouncementformServerce announcementformServerce)   
        {
            _announcementformServerce = announcementformServerce;
        }


        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="announcementform"></param>
        /// <returns></returns>
        [HttpPost]   
        public int Add(Announcementform announcementform)
        {  
            int i= _announcementformServerce.Add(announcementform);
            return i;
        }

        /// <summary>
        /// 显示分页
        /// </summary>
        /// <param name="announcementform"></param> 
        /// <returns></returns>
        [HttpGet]
        public List<Announcementform> Indexs()
        {
            var list = _announcementformServerce.GetAnnount();
            return list;
        }


        ///// <summary>
        ///// 反填数据
        ///// </summary>
        ///// <param name="announcementform"></param>
        ///// <returns></returns> 
        //[HttpGet("Get")]
        //public ActionResult<Announcementform> Get(int id)
        //{
        //    Announcementform ann = _announcementformServerce.Byid(id);
        //    return ann;
        //}


        /// <summary>
        ///删除
        /// </summary>
        /// <param name="announcementform"></param>
        /// <returns></returns> 
        [HttpDelete]
        public int Delete(int ids)
        {
            int i = _announcementformServerce.Delete(ids);
            return i;
        }


        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="announcementform"></param>
        /// <returns></returns> 
        [HttpPut]
        public int Update(Announcementform announcementform, int id)
        {
            int i = _announcementformServerce.Update(announcementform, id);
            return i;
        }
    }
}