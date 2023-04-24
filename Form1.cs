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
    public partial class FormFlowerShop : Form
    {
        private Stocks products = new Stocks();
        public FormFlowerShop()
        {
            InitializeComponent();
            editToolStripMenuItem.Enabled = false;
            editToolStripMenuItem1.Enabled = false;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFlower form = new FormFlower(null);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = new ListViewItem(form.flower.Name);
                item.SubItems.Add(form.flower.Color);
                item.SubItems.Add(form.flower.Price.ToString());
                item.SubItems.Add(form.flower.Quantity.ToString());

                item.Tag = form.flower;

                listViewProducts.Items.Add(item);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewProducts.SelectedItems.Count > 0)
            {
                Flower f = listViewProducts.SelectedItems[0].Tag as Flower;
                FormFlower form = new FormFlower(f);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem item = listViewProducts.SelectedItems[0];
                    item.Text = form.flower.Name;
                    item.SubItems[1].Text = form.flower.Color;
                    item.SubItems[2].Text = form.flower.Price.ToString();
                    item.SubItems[3].Text = form.flower.Quantity.ToString();

                    
                }
            }
        }

        private void listViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count > 0)
            {
                editToolStripMenuItem1.Enabled = true;
            }
            else
            {
                editToolStripMenuItem1.Enabled = false;
            }
        }

        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProducts.SelectedItems.Count > 0)
            {
                editToolStripMenuItem.Enabled = true;
            }
            else
            {
                editToolStripMenuItem.Enabled = false;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listViewProducts.SelectedItems.Count == 0)
            {
                editProductToolStripMenuItem.Enabled = false;
            }
            else
            {
                editProductToolStripMenuItem.Enabled = true;
            }
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormOrder form = new FormOrder(null);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = new ListViewItem(form.order.OrderDate.ToString());
                item.SubItems.Add(form.order.DaysDue.ToString());
                item.SubItems.Add(form.order.Value.ToString());
                item.SubItems.Add(form.order.Sender);
                item.SubItems.Add(form.order.Details);

                item.Tag = form.order;
                listViewOrders.Items.Add(item);
            }

        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count > 0)
            {
                Order order = listViewOrders.SelectedItems[0].Tag as Order;
                FormOrder form = new FormOrder(order);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem item = listViewOrders.SelectedItems[0];
                    item.SubItems[0].Text = form.order.OrderDate.ToString();
                    item.SubItems[1].Text = form.order.DaysDue.ToString();
                    item.SubItems[2].Text = form.order.Value.ToString();
                    item.SubItems[3].Text = form.order.Sender;
                    item.SubItems[4].Text = form.order.Details;
                }
            }
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            if (listViewOrders.SelectedItems.Count > 0)
            {
                editOrderToolStripMenuItem.Enabled = true;
            }
            else
            {
                editOrderToolStripMenuItem.Enabled = false;
            }
        }
    }
}
