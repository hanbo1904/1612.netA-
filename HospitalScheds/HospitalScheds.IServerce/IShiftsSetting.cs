using System;
using System.Collections.Generic;
using System.Text;


using HospitalScheds.Model;
using System.Data;

namespace HospitalScheds.IServerce
{
    /// <summary>
    /// 班次设置表
    /// </summary>
    public interface IShiftsSetting
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="shiftsSetting"></param>
        /// <returns></returns>
        int Add(IShiftsSetting shiftsSetting);

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        List<IShiftsSetting> GetShiftsSetting(string Name = "");

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        IShiftsSetting GetShiftsSetting(int Id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="shiftsSetting"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        int GetShiftsSetting(IShiftsSetting shiftsSetting, int Id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DelShiftsSetting(int Id);
    }
}
