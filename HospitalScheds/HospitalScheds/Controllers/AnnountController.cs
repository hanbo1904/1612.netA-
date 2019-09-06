using System;
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
    public class AnnountController : Controller
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
            int i = _announcementformServerce.Add(announcementform);
            return i;
        }


        /// <summary>
        /// 显示分页
        /// </summary>
        /// <param name="announcementform"></param> 
        /// <returns></returns>
        [HttpGet]
        public PageModel<Announcementform> Index(string Name = "", int pageIndex = 0, int pageSize = 3)
        {
            var list = _announcementformServerce.announcementform(Name, pageIndex, pageSize);
            return list;
        }


        /// <summary>
        /// 反填数据
        /// </summary>
        /// <param name="announcementform"></param>
        /// <returns></returns> 
        [HttpGet]
        public Announcementform Byid(int id)
        {
            Announcementform ann = _announcementformServerce.Byid(id);
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
            int i = _announcementformServerce.Delete(id);
            return i;
        }


        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="announcementform"></param>
        /// <returns></returns> 
        [HttpPost]
        public int Update(Announcementform announcementform,int id)
        {
            int i = _announcementformServerce.Update(announcementform,id);
            return i;
        }
    }
}