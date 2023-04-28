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
    }
}
