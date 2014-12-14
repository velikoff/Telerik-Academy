using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkExams
{
    class GSMTest
    {
        private GSM[] array = new GSM[3];
        public GSM Array { get; set; }
        public GSMTest()
        {
            this.array[0] = new GSM("Galaxy", "Samsung", "Yaneva", 500);
            this.array[1] = new GSM("Hero", "HTC", "Kliment", 450);
            this.array[2] = new GSM("Miro", "Sony", "Todorka", 700);
        }
        public void Print()
        {
            foreach (var item in array)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void PrintIPhone()
        {
            Console.WriteLine(GSM.iPhone4S.ToString());
        }

    }
}
