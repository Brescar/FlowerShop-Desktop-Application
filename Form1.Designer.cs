namespace FlowerShop
{
    partial class FormFlowerShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.columnHeaderProductsID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFlowerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFlowerPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFlowerStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.columnHeaderOrdersDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOrdersDaysLeft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOrdersValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOrdersSender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOrdersDetails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDelivery = new System.Windows.Forms.ListView();
            this.columnHeaderDeliveryDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDeliveryDaysLeft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDeliveryValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRecipient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDeliveryDetails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelProducts = new System.Windows.Forms.Label();
            this.labelOrders = new System.Windows.Forms.Label();
            this.labelDelivery = new System.Windows.Forms.Label();
            this.statusStripProducts = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTextProducts = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelNrOfProducts = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTextOrders = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelNrOfOrders = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTextDelivery = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDelivery = new System.Windows.Forms.ToolStripStatusLabel();
            this.columnHeaderProductsColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.statusStripProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.deliveryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1902, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // deliveryToolStripMenuItem
            // 
            this.deliveryToolStripMenuItem.Name = "deliveryToolStripMenuItem";
            this.deliveryToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.deliveryToolStripMenuItem.Text = "Delivery";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // listViewProducts
            // 
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderProductsID,
            this.columnHeaderFlowerName,
            this.columnHeaderProductsColor,
            this.columnHeaderFlowerPrice,
            this.columnHeaderFlowerStock});
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(699, 88);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(453, 544);
            this.listViewProducts.TabIndex = 2;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderProductsID
            // 
            this.columnHeaderProductsID.Text = "ID";
            this.columnHeaderProductsID.Width = 40;
            // 
            // columnHeaderFlowerName
            // 
            this.columnHeaderFlowerName.Text = "Name";
            this.columnHeaderFlowerName.Width = 120;
            // 
            // columnHeaderFlowerPrice
            // 
            this.columnHeaderFlowerPrice.Text = "Price $";
            this.columnHeaderFlowerPrice.Width = 55;
            // 
            // columnHeaderFlowerStock
            // 
            this.columnHeaderFlowerStock.Text = "Stock";
            this.columnHeaderFlowerStock.Width = 50;
            // 
            // listViewOrders
            // 
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderOrdersDate,
            this.columnHeaderOrdersDaysLeft,
            this.columnHeaderOrdersValue,
            this.columnHeaderOrdersSender,
            this.columnHeaderOrdersDetails});
            this.listViewOrders.HideSelection = false;
            this.listViewOrders.Location = new System.Drawing.Point(15, 88);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(625, 235);
            this.listViewOrders.TabIndex = 3;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderOrdersDate
            // 
            this.columnHeaderOrdersDate.Text = "Date due";
            this.columnHeaderOrdersDate.Width = 100;
            // 
            // columnHeaderOrdersDaysLeft
            // 
            this.columnHeaderOrdersDaysLeft.Text = "Days left";
            this.columnHeaderOrdersDaysLeft.Width = 70;
            // 
            // columnHeaderOrdersValue
            // 
            this.columnHeaderOrdersValue.Text = "Value $";
            // 
            // columnHeaderOrdersSender
            // 
            this.columnHeaderOrdersSender.Text = "Sender";
            this.columnHeaderOrdersSender.Width = 120;
            // 
            // columnHeaderOrdersDetails
            // 
            this.columnHeaderOrdersDetails.Text = "Details";
            this.columnHeaderOrdersDetails.Width = 120;
            // 
            // listViewDelivery
            // 
            this.listViewDelivery.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDeliveryDate,
            this.columnHeaderDeliveryDaysLeft,
            this.columnHeaderDeliveryValue,
            this.columnHeaderRecipient,
            this.columnHeaderDeliveryDetails});
            this.listViewDelivery.HideSelection = false;
            this.listViewDelivery.Location = new System.Drawing.Point(15, 397);
            this.listViewDelivery.Name = "listViewDelivery";
            this.listViewDelivery.Size = new System.Drawing.Size(625, 235);
            this.listViewDelivery.TabIndex = 4;
            this.listViewDelivery.UseCompatibleStateImageBehavior = false;
            this.listViewDelivery.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderDeliveryDate
            // 
            this.columnHeaderDeliveryDate.Text = "Date due";
            this.columnHeaderDeliveryDate.Width = 100;
            // 
            // columnHeaderDeliveryDaysLeft
            // 
            this.columnHeaderDeliveryDaysLeft.Text = "Days left";
            this.columnHeaderDeliveryDaysLeft.Width = 70;
            // 
            // columnHeaderDeliveryValue
            // 
            this.columnHeaderDeliveryValue.Text = "Value $";
            // 
            // columnHeaderRecipient
            // 
            this.columnHeaderRecipient.Text = "Recipient";
            this.columnHeaderRecipient.Width = 120;
            // 
            // columnHeaderDeliveryDetails
            // 
            this.columnHeaderDeliveryDetails.Text = "Details";
            this.columnHeaderDeliveryDetails.Width = 120;
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.Location = new System.Drawing.Point(696, 69);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(60, 16);
            this.labelProducts.TabIndex = 5;
            this.labelProducts.Text = "Products";
            // 
            // labelOrders
            // 
            this.labelOrders.AutoSize = true;
            this.labelOrders.Location = new System.Drawing.Point(12, 69);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(48, 16);
            this.labelOrders.TabIndex = 6;
            this.labelOrders.Text = "Orders";
            // 
            // labelDelivery
            // 
            this.labelDelivery.AutoSize = true;
            this.labelDelivery.Location = new System.Drawing.Point(12, 378);
            this.labelDelivery.Name = "labelDelivery";
            this.labelDelivery.Size = new System.Drawing.Size(57, 16);
            this.labelDelivery.TabIndex = 7;
            this.labelDelivery.Text = "Delivery";
            // 
            // statusStripProducts
            // 
            this.statusStripProducts.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripProducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTextProducts,
            this.toolStripStatusLabelNrOfProducts,
            this.toolStripStatusLabelTextOrders,
            this.toolStripStatusLabelNrOfOrders,
            this.toolStripStatusLabelTextDelivery,
            this.toolStripStatusLabelDelivery});
            this.statusStripProducts.Location = new System.Drawing.Point(0, 1007);
            this.statusStripProducts.Name = "statusStripProducts";
            this.statusStripProducts.Size = new System.Drawing.Size(1902, 26);
            this.statusStripProducts.TabIndex = 8;
            // 
            // toolStripStatusLabelTextProducts
            // 
            this.toolStripStatusLabelTextProducts.Name = "toolStripStatusLabelTextProducts";
            this.toolStripStatusLabelTextProducts.Size = new System.Drawing.Size(214, 20);
            this.toolStripStatusLabelTextProducts.Text = "Unique products / Total stock : ";
            // 
            // toolStripStatusLabelNrOfProducts
            // 
            this.toolStripStatusLabelNrOfProducts.Name = "toolStripStatusLabelNrOfProducts";
            this.toolStripStatusLabelNrOfProducts.Size = new System.Drawing.Size(102, 20);
            this.toolStripStatusLabelNrOfProducts.Text = "nr of products";
            // 
            // toolStripStatusLabelTextOrders
            // 
            this.toolStripStatusLabelTextOrders.Name = "toolStripStatusLabelTextOrders";
            this.toolStripStatusLabelTextOrders.Size = new System.Drawing.Size(203, 20);
            this.toolStripStatusLabelTextOrders.Text = "        |          Orders / $ owed : ";
            // 
            // toolStripStatusLabelNrOfOrders
            // 
            this.toolStripStatusLabelNrOfOrders.Name = "toolStripStatusLabelNrOfOrders";
            this.toolStripStatusLabelNrOfOrders.Size = new System.Drawing.Size(86, 20);
            this.toolStripStatusLabelNrOfOrders.Text = "nr of orders";
            // 
            // toolStripStatusLabelTextDelivery
            // 
            this.toolStripStatusLabelTextDelivery.Name = "toolStripStatusLabelTextDelivery";
            this.toolStripStatusLabelTextDelivery.Size = new System.Drawing.Size(248, 20);
            this.toolStripStatusLabelTextDelivery.Text = "        |          Deliveries / $ to receive :";
            // 
            // toolStripStatusLabelDelivery
            // 
            this.toolStripStatusLabelDelivery.Name = "toolStripStatusLabelDelivery";
            this.toolStripStatusLabelDelivery.Size = new System.Drawing.Size(107, 20);
            this.toolStripStatusLabelDelivery.Text = "nr of deliveries";
            // 
            // columnHeaderProductsColor
            // 
            this.columnHeaderProductsColor.Text = "Color";
            // 
            // FormFlowerShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.statusStripProducts);
            this.Controls.Add(this.labelDelivery);
            this.Controls.Add(this.labelOrders);
            this.Controls.Add(this.labelProducts);
            this.Controls.Add(this.listViewDelivery);
            this.Controls.Add(this.listViewOrders);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormFlowerShop";
            this.Text = "FlowerShop";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStripProducts.ResumeLayout(false);
            this.statusStripProducts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.ListView listViewDelivery;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.Label labelOrders;
        private System.Windows.Forms.Label labelDelivery;
        private System.Windows.Forms.StatusStrip statusStripProducts;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTextProducts;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNrOfProducts;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTextOrders;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNrOfOrders;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTextDelivery;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDelivery;
        private System.Windows.Forms.ColumnHeader columnHeaderProductsID;
        private System.Windows.Forms.ColumnHeader columnHeaderFlowerName;
        private System.Windows.Forms.ColumnHeader columnHeaderFlowerPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderFlowerStock;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeaderDeliveryDate;
        private System.Windows.Forms.ColumnHeader columnHeaderDeliveryValue;
        private System.Windows.Forms.ColumnHeader columnHeaderRecipient;
        private System.Windows.Forms.ColumnHeader columnHeaderDeliveryDaysLeft;
        private System.Windows.Forms.ColumnHeader columnHeaderDeliveryDetails;
        private System.Windows.Forms.ColumnHeader columnHeaderOrdersDate;
        private System.Windows.Forms.ColumnHeader columnHeaderOrdersDaysLeft;
        private System.Windows.Forms.ColumnHeader columnHeaderOrdersValue;
        private System.Windows.Forms.ColumnHeader columnHeaderOrdersSender;
        private System.Windows.Forms.ColumnHeader columnHeaderOrdersDetails;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeaderProductsColor;
    }
}

