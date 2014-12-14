using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkExams
{
    
    public class Battery
    {
        public enum BatteryType { Lilon, NiMH, NiCd, LiPoly }
        public string Model { get; private set; }
        private int hoursIdle;
        private int hoursTalk;
       // properties
        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Hours should be  positive value");
                }
              this.hoursTalk = value;
            }
        }
        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Hours should be positive value");
                }
            this.hoursIdle = value;
            }
        }
       // constructors
        public Battery ( string model, int hoursIdle, int hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }
        public Battery ( string model) 
            : this (model, 0, 0)
        {
        }

    }
}
