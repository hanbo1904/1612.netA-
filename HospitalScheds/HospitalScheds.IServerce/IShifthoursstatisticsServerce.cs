using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;
using System.Data;
using PagedList.Mvc;
using Webdiyer.WebControls;

namespace HospitalScheds.IServerce
{
  public  interface IShifthoursstatisticsServerce
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="shifthoursstatistics"></param>
        /// <returns></returns>
        int Add(Shifthoursstatistics shifthoursstatistics);

        /// <summary>
        /// 显示分页
        /// </summary>
        /// <typeparam name="Shifthoursstatistics"></typeparam>
        /// <param name="Name"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        PageModel<Shifthoursstatistics> shifthoursstatistics (String Name = "",int pageIndex=0,int pageSize=3);


        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Delete(int id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="dd"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        int Update(Shifthoursstatistics shifthoursstatistics, int id);

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        List<Shifthoursstatistics> shifthoursstatistics();

    }
}
