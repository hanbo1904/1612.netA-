﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using HospitalScheds.Model;
using HospitalScheds.IServerce;
using HospitalScheds.Serverce;

namespace HospitalScheds.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolitaireSetController : Controller
    {
        /// <summary>
        /// 定义私有变量
        /// </summary>
        public ISolitaireSetServerce _solitaireSetServerce;

        /// <summary>
        /// 构造函数注入
        /// </summary>
        /// <param name="organization"></param>
        public SolitaireSetController(ISolitaireSetServerce solitaireSetServerce)
        {
            _solitaireSetServerce = solitaireSetServerce;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="announcementform"></param>
        /// <returns></returns>
        [HttpPost]
        public int Add(SolitaireSet solitaireSet)
        {
            int i = _solitaireSetServerce.Add(solitaireSet);
            return i;
        }


        /// <summary>
        /// 显示分页
        /// </summary>
        /// <param name="announcementform"></param> 
        /// <returns></returns>
        [HttpGet]
        public PageModel<SolitaireSet> Index(string Name = "", int pageIndex = 0, int pageSize = 3)
        {
            var list = _solitaireSetServerce.GetSolitaireSet(Name, pageIndex, pageSize);
            return list;
        }


        /// <summary>
        /// 反填数据
        /// </summary>
        /// <param name="announcementform"></param>
        /// <returns></returns> 
        [HttpGet]
        public SolitaireSet Byid(int id)
        {
            SolitaireSet ann = _solitaireSetServerce.GetSolitaireSet(id);
            return ann;
        }


        /// <summary>
        ///删除
        /// </summary>
        /// <param name="announcementform"></param>
        /// <returns></returns> 
        [HttpPost]
        public int Delete(int id)
        {
            int i = _solitaireSetServerce.DelSolitaire(id);
            return i;
        }


        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="announcementform"></param>
        /// <returns></returns> 
        [HttpPost]
        public int Update(SolitaireSet solitaireSet, int id)
        {
            int i = _solitaireSetServerce.GetSolitaireSet(solitaireSet, id);
            return i;
        }
    }
}