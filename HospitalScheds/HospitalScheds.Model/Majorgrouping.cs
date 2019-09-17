using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    /// <summary>
    /// 专业分组设置
    /// </summary>
    public class Majorgrouping 
    {
        public int id { get; set; }                    //ID  
        public string professional { get; set; }       //专业组颜色
        public string   majorgroupingname{ get; set; }  //名称
        public string therelevant { get; set; }        //相关科室
        public string teaching { get; set; }           //带教
        public string majorgroupingleader { get; set; }//组长
        public string majorgroupingcrew { get; set; }  //组员
    }                                                  
}
