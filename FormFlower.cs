using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShop
{
    public partial class FormFlower : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();
        public Flower flower;
        public FormFlower(Flower f)
        {
            InitializeComponent();

            if (f == null)
            {
                buttonFlowerAdd.Text = "ADD";
                flower = new Flower();
            }
            else
            {
                buttonFlowerAdd.Text = "EDIT";
                flower = f;

                textBoxFlowerName.Text = flower.Name;
                textBoxFlowerColor.Text = flower.Color;
                textBoxFlowerPrice.Text = flower.Price.ToString();
                textBoxFlowerStock.Text = flower.Quantity.ToString();
            }
        }

        private void buttonFlowerAdd_Click(object sender, EventArgs e)
        {
            flower.Name = textBoxFlowerName.Text;
            flower.Color = textBoxFlowerColor.Text;
            flower.Price = double.Parse(textBoxFlowerPrice.Text);
            flower.Quantity = int.Parse(textBoxFlowerStock.Text);
        }

        private void textBoxFlowerName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxFlowerName.Text.Length < 3)
            {
                errorProvider.SetError(textBoxFlowerName,
                    "Name must be at least 3 characters long");
                if (ActiveControl != buttonFlowerCancel)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                errorProvider.SetError(textBoxFlowerName, "");
            }
        }

        private void textBoxFlowerColor_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxFlowerColor.Text.Length < 3)
            {
                errorProvider.SetError(textBoxFlowerColor,
                    "Name must be at least 3 characters long");
                if (ActiveControl != buttonFlowerCancel)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                errorProvider.SetError(textBoxFlowerColor, "");
            }
        }

        private void textBoxFlowerPrice_Validating(object sender, CancelEventArgs e)
        {
            string input = textBoxFlowerPrice.Text;
            double price;
            bool isNumber = double.TryParse(input, out price);
            if (!isNumber)
            {
                errorProvider.SetError(textBoxFlowerPrice, "Price needs to be a rational number (ex: 2.5)");
                if (ActiveControl != buttonFlowerCancel)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                errorProvider.SetError(textBoxFlowerPrice, "");
            }
        }

        private void textBoxFlowerStock_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(textBoxFlowerStock.Text, out int stock))
            {
                errorProvider.SetError(textBoxFlowerStock, "Stock needs to be an integer (ex: 15)");
                if (ActiveControl != buttonFlowerCancel)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                errorProvider.SetError(textBoxFlowerStock, "");
            }
        }
    }
}
