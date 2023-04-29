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
            //for listViewProducts
            editToolStripMenuItem.Enabled = false;
            deleteToolStripMenuItem.Enabled = false;
            //for listViewOrders
            editToolStripMenuItem1.Enabled = false;
            deleteToolStripMenuItem1.Enabled = false;
            //for listViewDelivery
            editToolStripMenuItem2.Enabled = false;
            deleteToolStripMenuItem2.Enabled = false;
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
                deleteToolStripMenuItem1.Enabled = true;
            }
            else
            {
                editToolStripMenuItem1.Enabled = false;
                deleteToolStripMenuItem1.Enabled = false;
            }
        }

        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProducts.SelectedItems.Count > 0)
            {
                editToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
            }
            else
            {
                editToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listViewProducts.SelectedItems.Count == 0)
            {
                editProductToolStripMenuItem.Enabled = false;
                deleteProductToolStripMenuItem.Enabled = false;
            }
            else
            {
                editProductToolStripMenuItem.Enabled = true;
                deleteProductToolStripMenuItem.Enabled = true;
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
                deleteOrderToolStripMenuItem.Enabled = true;
            }
            else
            {
                editOrderToolStripMenuItem.Enabled = false;
                deleteOrderToolStripMenuItem.Enabled = false;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewProducts.SelectedItems.Count > 0)
            {
                listViewProducts.SelectedItems[0].Remove();
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count > 0)
            {
                listViewOrders.SelectedItems[0].Remove();
            }
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormDelivery form = new FormDelivery(null);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = new ListViewItem(form.delivery.DeliveryDate.ToString());
                item.SubItems.Add(form.delivery.DaysDue.ToString());
                item.SubItems.Add(form.delivery.Value.ToString());
                item.SubItems.Add(form.delivery.Recipient);
                item.SubItems.Add(form.delivery.Details);

                item.Tag = form.delivery;
                listViewDelivery.Items.Add(item);
            }
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (listViewDelivery.SelectedItems.Count > 0)
            {
                Delivery delivery = listViewDelivery.SelectedItems[0].Tag as Delivery;
                FormDelivery form = new FormDelivery(delivery);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem item = listViewDelivery.SelectedItems[0];
                    item.SubItems[0].Text = form.delivery.DeliveryDate.ToString();
                    item.SubItems[1].Text = form.delivery.DaysDue.ToString();
                    item.SubItems[2].Text = form.delivery.Value.ToString();
                    item.SubItems[3].Text = form.delivery.Recipient;
                    item.SubItems[4].Text = form.delivery.Details;
                }
            }
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (listViewDelivery.SelectedItems.Count > 0)
            {
                listViewDelivery.SelectedItems[0].Remove();
            }
        }

        private void listViewDelivery_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDelivery.SelectedItems.Count > 0)
            {
                editToolStripMenuItem2.Enabled = true;
                deleteToolStripMenuItem2.Enabled = true;
            }
            else
            {
                editToolStripMenuItem2.Enabled = false;
                deleteToolStripMenuItem2.Enabled = false;
            }
        }

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {
            if (listViewDelivery.SelectedItems.Count > 0)
            {
                editDeliveryToolStripMenuItem.Enabled = true;
                deleteDeliveryToolStripMenuItem.Enabled = true;
            }
            else
            {
                editDeliveryToolStripMenuItem.Enabled = false;
                deleteDeliveryToolStripMenuItem.Enabled = false;
            }
        }
    }
}
