using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    [Serializable]
    public class Order : ICloneable
    {
        private DateTime orderDate;
        private int daysDue;
        private double value;
        private string sender;
        private string details;

        public Order() { }

        public Order(DateTime orderDate, double value, string sender, string details)
        {
            this.orderDate = orderDate;
            this.daysDue = NrDaysDue(this.orderDate);
            this.value = value;
            this.sender = sender;
            this.details = details;
        }

        private int NrDaysDue(DateTime orderDate)
        {
            TimeSpan maxInterval = TimeSpan.FromDays(28);
            TimeSpan minInterval = TimeSpan.FromDays(0);
            DateTime currentDate = DateTime.Now;

            TimeSpan interval = orderDate.Subtract(currentDate);
            if (interval <= maxInterval && interval >= minInterval)
            {
                return interval.Days;
            }
            else
            {
                return -1;
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { 
                orderDate = value;
                daysDue = NrDaysDue(value);
            }
        }
        public int DaysDue
        {
            get { return daysDue; }
        }
        public double Value
        {
            get { return value; }
            set { this.value = value; }
        }
        public string Sender
        {
            get { return sender; }
            set { sender = value; }
        }
        public string Details
        {
            get { return details; }
            set { details = value; }
        }

    }
}
