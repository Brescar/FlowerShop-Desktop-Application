using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShop
{
    public partial class FormFlowerShop : Form
    {
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void productsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "Products files *.prd |*.prd";
            fd.CheckPathExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                List<Flower> listP = new List<Flower>();

                foreach (ListViewItem item in listViewProducts.Items)
                {
                    listP.Add((Flower)item.Tag);
                }

                BinaryFormatter serializer = new BinaryFormatter();
                Stream file = File.Create(fd.FileName);
                try
                {
                    serializer.Serialize(file, listP);
                    file.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ordersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "Orders files *.ord |*.ord";
            fd.CheckPathExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                List<Order> listO = new List<Order>();

                foreach (ListViewItem item in listViewOrders.Items)
                {
                    listO.Add((Order)item.Tag);
                }

                BinaryFormatter serializer = new BinaryFormatter();
                Stream file = File.Create(fd.FileName);
                try
                {
                    serializer.Serialize(file, listO);
                    file.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void deliveryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "Delivery files *.dlr |*.dlr";
            fd.CheckPathExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                List<Delivery> listD = new List<Delivery>();

                foreach (ListViewItem item in listViewDelivery.Items)
                {
                    listD.Add((Delivery)item.Tag);
                }

                BinaryFormatter serializer = new BinaryFormatter();
                Stream file = File.Create(fd.FileName);
                try
                {
                    serializer.Serialize(file, listD);
                    file.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void productsToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Products files *.prd |*.prd";
            fd.CheckFileExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                List<Flower> listP = new List<Flower>();

                BinaryFormatter serializer = new BinaryFormatter();
                try
                {
                    Stream fisier = File.OpenRead(fd.FileName);
                    listP.AddRange((List<Flower>)serializer.Deserialize(fisier));
                    fisier.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                foreach (Flower f in listP)
                {
                    ListViewItem item = new ListViewItem(
                        new string[] { f.Name, f.Color, f.Price.ToString(), f.Quantity.ToString() });
                    item.Tag = f;
                    listViewProducts.Items.Add(item);
                }
            }
        }

        private void ordersToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Orders files *.ord |*.ord";
            fd.CheckFileExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                
                List<Order> listO = new List<Order>();
            
                BinaryFormatter serializer = new BinaryFormatter();
                try
                {
                    Stream fisier = File.OpenRead(fd.FileName);
                    listO.AddRange((List<Order>)serializer.Deserialize(fisier));
                    fisier.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                foreach (Order o in listO)
                {
                    ListViewItem item = new ListViewItem(
                        new string[] { o.OrderDate.ToString(), o.DaysDue.ToString(), o.Value.ToString(), o.Sender, o.Details });
                    item.Tag = o;
                    listViewOrders.Items.Add(item);
                }
            }
        }

        private void deliveryToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Delivery files *.dlr |*.dlr";
            fd.CheckFileExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                List<Delivery> listD = new List<Delivery>();

                BinaryFormatter serializer = new BinaryFormatter();
                try
                {
                    Stream fisier = File.OpenRead(fd.FileName);
                    listD.AddRange((List<Delivery>)serializer.Deserialize(fisier));
                    fisier.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                foreach (Delivery d in listD)
                {
                    ListViewItem item = new ListViewItem(
                                               new string[] { d.DeliveryDate.ToString(), d.DaysDue.ToString(), d.Value.ToString(), d.Recipient, d.Details });
                    item.Tag = d;
                    listViewDelivery.Items.Add(item);
                }
            }
        }
    }
}
