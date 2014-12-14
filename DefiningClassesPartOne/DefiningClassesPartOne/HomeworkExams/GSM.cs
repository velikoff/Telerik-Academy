using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkExams
{
    public class GSM
    {
        private static Battery batteryIPhone4S = new Battery(Battery.BatteryType.Lilon.ToString(), 100, 20);
        private static Display displayIPhone4S = new Display(4.5, 1600000);

        public string Model { get; private set; }
        public string Manufacturer { get; private set; }
        private decimal price;
        public string Owner { get; private set; }
        public Battery Battery { get; set; }
        public Display Display { get; set; }
        //static field
        static internal  GSM iPhone4S = new GSM("IPhone4S", "Apple", "Velikov", 1050, batteryIPhone4S, displayIPhone4S);
        //properties
        private List<Call> callHistory = new List<Call>();
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Price should be positive value");
                }
            this.price = value;
            }
        }
        public GSM IPhone4S { get; private set; }

        // constructors
        public GSM (string model, string manufacturer, string owner, decimal price, Battery battery, Display display)
         {
             this.Model = model;
             this.Owner = owner;
             this.Price = price;
             this.Battery = battery;
             this.Display = display;
         }
        public GSM (string model, string manufacturer)
            : this (model, manufacturer, null, 0, null, null)
        {
        }
        public GSM (string model, string manufacturer, string owner)
            : this (model, manufacturer, owner, 0, null, null)
        {
        }
        public GSM (string model, string manufacturer, string owner, decimal price)
            : this (model, manufacturer, owner, price, null, null)
        {
        }

        // methods
        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.AppendLine("GSM");
            toString.AppendLine("Model: " + this.Model + "\n Manufacturer: " + this.Manufacturer);
            toString.AppendLine("Owner: " + this.Owner + "\n Price: " + this.Price);
            if (this.Battery != null)
            {
                toString.AppendLine("Battery model: " + this.Battery.Model);
                toString.AppendLine("Battery hours talk: " + this.Battery.HoursTalk);
                toString.AppendLine("Battery hours idle: " + this.Battery.HoursIdle);
            }
            if (this.Display != null)
            {
                toString.AppendLine("Display size: " + this.Display.Size);
                toString.AppendLine("Display number of colors: " + this.Display.NumberOfColors);
            }
            return toString.ToString();
        }

        
        public void AddCall(string number, int duration)
        {
            Call call = new Call(number, duration);
            callHistory.Add(call);
        }
        public void RemoveCall(string number, int duration)
        {
            for (int i = callHistory.Count - 1; i >= 0; i--)
            {
             if ((number == callHistory[i].DialedPhone && duration == callHistory[i].Duration))
                callHistory.RemoveAt(i);   
            }
        }
        public void ClearHistory()
        {
            callHistory.Clear();
        }
        public double CalcTotalPrice(double pricePerMin)
        {
            double minutes = 0;
            foreach (var item in callHistory)
            {
                minutes += item.Duration;
            }
            return pricePerMin * (minutes / 60);
        }
        static void Main()
        {
            Battery battery = new Battery("Battery", 120, 17);
            Display display = new Display(3.5, 22);
            GSM mobileTwo = new GSM("3310", "Nokia", "Jordanov", 110, battery, display);
            mobileTwo.AddCall("0898757010", 32);
            mobileTwo.AddCall("0854357539", 72);
            mobileTwo.AddCall("0984343424", 24);
            Console.WriteLine(mobileTwo.CalcTotalPrice(1));
            int max = 0;
            string number = "";
            foreach (var item in mobileTwo.callHistory)
            {
                if (max < item.Duration)
                {
                    max = item.Duration;
                    number = item.DialedPhone;
                }
            }
            mobileTwo.RemoveCall(number, max);
            Console.WriteLine(mobileTwo.CalcTotalPrice(1));
            mobileTwo.ClearHistory();
        }
    }
}
