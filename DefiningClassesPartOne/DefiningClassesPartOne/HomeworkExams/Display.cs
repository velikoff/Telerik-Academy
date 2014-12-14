using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkExams
{
    public class Display
    {
        private double size;
        private long numberOfColors;
      
        // properties
        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Size should be positive value");
                }
              this.size = value;
            }
        }
        public long NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of color should be positive value");
                }
            this.numberOfColors = value;
            }
        }
       // constructors 
        public Display(double size, long numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }
        public Display(double size)
            : this(size, 0)
        {
        }
        
    }
}
