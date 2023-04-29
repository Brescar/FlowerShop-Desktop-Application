using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShop
{
    public partial class FormDelivery : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();
        public Delivery delivery;
        public FormDelivery(Delivery d)
        {
            InitializeComponent();
            if (d == null)
            {
                buttonDeliveryAdd.Text = "ADD";

                delivery = new Delivery();
            }
            else
            {
                buttonDeliveryAdd.Text = "EDIT";

                delivery = d;

                dateTimePickerDelivery.Value = d.DeliveryDate;
                textBoxDeliveryValue.Text = d.Value.ToString();
                textBoxDeliverySender.Text = d.Recipient;
                textBoxDeliveryDetails.Text = d.Details;
            }
            dateTimePickerDelivery.MaxDate = DateTime.Now.AddDays(28);
            dateTimePickerDelivery.MinDate = DateTime.Now.AddDays(1);
        
        }

        private void buttonDeliveryAdd_Click(object sender, EventArgs e)
        {
            delivery.DeliveryDate = dateTimePickerDelivery.Value;
            delivery.Value = double.Parse(textBoxDeliveryValue.Text);
            delivery.Recipient = textBoxDeliverySender.Text;
            delivery.Details = textBoxDeliveryDetails.Text;
        }

        private void dateTimePickerDelivery_Validating(object sender, CancelEventArgs e)
        {
            TimeSpan maxInterval = TimeSpan.FromDays(28);
            TimeSpan minInterval = TimeSpan.FromDays(0);
            DateTime currentDate = DateTime.Now;

            TimeSpan interval = dateTimePickerDelivery.Value.Subtract(currentDate);
            if (interval > maxInterval || interval < minInterval)
            {
                errorProvider.SetError(dateTimePickerDelivery, "Delivery cannot arrive today nor later than 28 days from now");
                if (ActiveControl != buttonDeliveryCancel)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                errorProvider.SetError(dateTimePickerDelivery, "");
                //e.Cancel = false;
            }
        }

        private void textBoxDeliveryValue_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(textBoxDeliveryValue.Text, out double value))
            {
                errorProvider.SetError(textBoxDeliveryValue, "Value needs to be a rational number (e.g. 56.2)");
                if (ActiveControl != buttonDeliveryCancel)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                errorProvider.SetError(textBoxDeliveryValue, "");
            }
        }

        private void textBoxDeliverySender_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxDeliverySender.Text.Length < 3)
            {
                errorProvider.SetError(textBoxDeliverySender, "Name needs to be at least 3 characters long");
                if (ActiveControl != buttonDeliveryCancel)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                errorProvider.SetError(textBoxDeliverySender, "");
            }
        }
    }
}
