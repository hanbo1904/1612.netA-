using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    //法定节日
    public class Statutoryholiday : BaseEntity
    {
        public int Id { get; set; }//主键ID
        public string Holiday { get; set; } //节日
    }
}
