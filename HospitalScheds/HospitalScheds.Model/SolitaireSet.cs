using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    //接龙设置表
    public class SolitaireSet : BaseEntity
    {
        public int ID { get; set; }                     //ID
        public string SolitaireShifts { get; set; }     //接龙班次
        public string SolitaireDays { get; set; }       //接龙周期
        public int SolitaireOrder { get; set; }         //接龙排序
        public string PeopleGroup { get; set; }         //组内人员
        public string GroupLeader { get; set; }         //组长
        public int SolitaireOrders { get; set; }        //顺序
    }
}
