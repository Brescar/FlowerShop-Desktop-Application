using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    [Serializable]
    public class Delivery : ICloneable
    {
        private DateTime deliveryDate;
        private int daysDue;
        private double value;
        private string recipient;
        private string details;

        public Delivery() { }

        public Delivery(DateTime deliveryDate, double value, string sender, string details)
        {
            this.deliveryDate = deliveryDate;
            this.daysDue = NrDaysDue(this.deliveryDate);
            this.value = value;
            this.recipient = sender;
            this.details = details;
        }

        private int NrDaysDue(DateTime deliveryDate)
        {
            TimeSpan maxInterval = TimeSpan.FromDays(28);
            TimeSpan minInterval = TimeSpan.FromDays(0);
            DateTime currentDate = DateTime.Now;

            TimeSpan interval = deliveryDate.Subtract(currentDate);
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

        public DateTime DeliveryDate
        {
            get { return deliveryDate; }
            set
            {
                deliveryDate = value;
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
        public string Recipient
        {
            get { return recipient; }
            set { recipient = value; }
        }
        public string Details
        {
            get { return details; }
            set { details = value; }
        }

    }
}
