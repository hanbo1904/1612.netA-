using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using HospitalScheds.Model;

namespace HospitalScheds.IServerce
{
    /// <summary>
    /// 接龙设置表
    /// </summary>
    
    public interface ISolitaireSetServerce
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="solitaireSet"></param>
        /// <returns></returns>
        int Add(SolitaireSet solitaireSet);

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        List<SolitaireSet> GetSolitaireSet(string Name = "");

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        SolitaireSet GetSolitaireSet(int Id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="solitaireSet"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        int GetSolitaireSet(SolitaireSet solitaireSet, int Id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DelSolitaireSet(int Id);
    }
}
