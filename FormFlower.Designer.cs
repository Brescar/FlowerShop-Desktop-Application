namespace FlowerShop
{
    partial class FormFlower
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
            this.labelFlowerName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFlowerName = new System.Windows.Forms.TextBox();
            this.textBoxFlowerColor = new System.Windows.Forms.TextBox();
            this.textBoxFlowerPrice = new System.Windows.Forms.TextBox();
            this.textBoxFlowerStock = new System.Windows.Forms.TextBox();
            this.buttonFlowerAdd = new System.Windows.Forms.Button();
            this.buttonFlowerCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFlowerName
            // 
            this.labelFlowerName.AutoSize = true;
            this.labelFlowerName.Location = new System.Drawing.Point(236, 53);
            this.labelFlowerName.Name = "labelFlowerName";
            this.labelFlowerName.Size = new System.Drawing.Size(47, 16);
            this.labelFlowerName.TabIndex = 6;
            this.labelFlowerName.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stock:";
            // 
            // textBoxFlowerName
            // 
            this.textBoxFlowerName.Location = new System.Drawing.Point(303, 50);
            this.textBoxFlowerName.Name = "textBoxFlowerName";
            this.textBoxFlowerName.Size = new System.Drawing.Size(234, 22);
            this.textBoxFlowerName.TabIndex = 0;
            this.textBoxFlowerName.Text = "Name";
            this.textBoxFlowerName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxFlowerName_Validating);
            // 
            // textBoxFlowerColor
            // 
            this.textBoxFlowerColor.Location = new System.Drawing.Point(303, 125);
            this.textBoxFlowerColor.Name = "textBoxFlowerColor";
            this.textBoxFlowerColor.Size = new System.Drawing.Size(234, 22);
            this.textBoxFlowerColor.TabIndex = 1;
            this.textBoxFlowerColor.Text = "Color";
            // 
            // textBoxFlowerPrice
            // 
            this.textBoxFlowerPrice.Location = new System.Drawing.Point(303, 206);
            this.textBoxFlowerPrice.Name = "textBoxFlowerPrice";
            this.textBoxFlowerPrice.Size = new System.Drawing.Size(234, 22);
            this.textBoxFlowerPrice.TabIndex = 2;
            this.textBoxFlowerPrice.Text = "0";
            // 
            // textBoxFlowerStock
            // 
            this.textBoxFlowerStock.Location = new System.Drawing.Point(303, 280);
            this.textBoxFlowerStock.Name = "textBoxFlowerStock";
            this.textBoxFlowerStock.Size = new System.Drawing.Size(234, 22);
            this.textBoxFlowerStock.TabIndex = 3;
            this.textBoxFlowerStock.Text = "0";
            // 
            // buttonFlowerAdd
            // 
            this.buttonFlowerAdd.BackColor = System.Drawing.Color.Lime;
            this.buttonFlowerAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonFlowerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFlowerAdd.Location = new System.Drawing.Point(303, 341);
            this.buttonFlowerAdd.Name = "buttonFlowerAdd";
            this.buttonFlowerAdd.Size = new System.Drawing.Size(91, 68);
            this.buttonFlowerAdd.TabIndex = 4;
            this.buttonFlowerAdd.Text = "ADD";
            this.buttonFlowerAdd.UseVisualStyleBackColor = false;
            this.buttonFlowerAdd.Click += new System.EventHandler(this.buttonFlowerAdd_Click);
            // 
            // buttonFlowerCancel
            // 
            this.buttonFlowerCancel.BackColor = System.Drawing.Color.Red;
            this.buttonFlowerCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonFlowerCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFlowerCancel.Location = new System.Drawing.Point(446, 341);
            this.buttonFlowerCancel.Name = "buttonFlowerCancel";
            this.buttonFlowerCancel.Size = new System.Drawing.Size(91, 68);
            this.buttonFlowerCancel.TabIndex = 5;
            this.buttonFlowerCancel.Text = "CANCEL";
            this.buttonFlowerCancel.UseVisualStyleBackColor = false;
            // 
            // FormFlower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFlowerCancel);
            this.Controls.Add(this.buttonFlowerAdd);
            this.Controls.Add(this.textBoxFlowerStock);
            this.Controls.Add(this.textBoxFlowerPrice);
            this.Controls.Add(this.textBoxFlowerColor);
            this.Controls.Add(this.textBoxFlowerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFlowerName);
            this.Name = "FormFlower";
            this.Text = "FormFlower";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFlowerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFlowerName;
        private System.Windows.Forms.TextBox textBoxFlowerColor;
        private System.Windows.Forms.TextBox textBoxFlowerPrice;
        private System.Windows.Forms.TextBox textBoxFlowerStock;
        private System.Windows.Forms.Button buttonFlowerAdd;
        private System.Windows.Forms.Button buttonFlowerCancel;
    }
}