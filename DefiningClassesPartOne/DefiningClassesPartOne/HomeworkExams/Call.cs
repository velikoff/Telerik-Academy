using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkExams
{
    class Call
    {
        public DateTime DateTime { get; set; }
        public int Duration { get; set; }
        public string DialedPhone { get; set; }
        public Call( string dialedPhone, int duration)
        {
            this.Duration = duration;
            this.DialedPhone = dialedPhone;
            this.DateTime = DateTime.Now;
        }
        

    }
}
