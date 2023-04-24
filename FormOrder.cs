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
    public partial class FormOrder : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();
        public Order order;
        public FormOrder(Order o)
        {
            InitializeComponent();
            if (o == null)
            {
                buttonOrderAdd.Text = "ADD";

                order = new Order();
            }
            else
            {
                buttonOrderAdd.Text = "EDIT";

                order = o;

                dateTimePickerOrder.Value = o.OrderDate;
                textBoxOrderValue.Text = o.Value.ToString();
                textBoxOrderSender.Text = o.Sender;
                textBoxOrderDetails.Text = o.Details;
            }
            dateTimePickerOrder.MaxDate = DateTime.Now.AddDays(28);
            dateTimePickerOrder.MinDate = DateTime.Now.AddDays(1);
        }

        private void buttonOrderAdd_Click(object sender, EventArgs e)
        {
            order.OrderDate = dateTimePickerOrder.Value;
            order.Value = double.Parse(textBoxOrderValue.Text);
            order.Sender = textBoxOrderSender.Text;
            order.Details = textBoxOrderDetails.Text;
        }

        private void dateTimePickerOrder_Validating(object sender, CancelEventArgs e)
        {
            TimeSpan maxInterval = TimeSpan.FromDays(28);
            TimeSpan minInterval = TimeSpan.FromDays(0);
            DateTime currentDate = DateTime.Now;

            TimeSpan interval = dateTimePickerOrder.Value.Subtract(currentDate);
            if (interval > maxInterval || interval < minInterval)
            {
                errorProvider.SetError(dateTimePickerOrder, "Order cannot arrive today nor later than 28 days from now");
                if (ActiveControl != buttonOrderCancel)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                errorProvider.SetError(dateTimePickerOrder, "");
                //e.Cancel = false;
            }
        }

        private void textBoxOrderValue_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(textBoxOrderValue.Text, out double value))
            {
                errorProvider.SetError(textBoxOrderValue, "Value needs to be a rational number (e.g. 56.2)");
                if (ActiveControl != buttonOrderCancel)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                errorProvider.SetError(textBoxOrderValue, "");
            }
        }

        private void textBoxOrderSender_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxOrderSender.Text.Length < 3)
            {
                errorProvider.SetError(textBoxOrderSender, "Name needs to be at least 3 characters long");
                if (ActiveControl != buttonOrderCancel)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                errorProvider.SetError(textBoxOrderSender, "");
            }
        }
    }
}
