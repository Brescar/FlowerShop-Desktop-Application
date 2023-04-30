namespace FlowerShop
{
    partial class FormOrder
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
            this.dateTimePickerOrder = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOrderValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOrderSender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOrderDetails = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOrderAdd = new System.Windows.Forms.Button();
            this.buttonOrderCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerOrder
            // 
            this.dateTimePickerOrder.Location = new System.Drawing.Point(249, 60);
            this.dateTimePickerOrder.MinDate = new System.DateTime(2023, 4, 24, 0, 0, 0, 0);
            this.dateTimePickerOrder.Name = "dateTimePickerOrder";
            this.dateTimePickerOrder.Size = new System.Drawing.Size(281, 22);
            this.dateTimePickerOrder.TabIndex = 0;
            this.dateTimePickerOrder.Value = new System.DateTime(2023, 4, 24, 19, 30, 11, 0);
            this.dateTimePickerOrder.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePickerOrder_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date due : ";
            // 
            // textBoxOrderValue
            // 
            this.textBoxOrderValue.Location = new System.Drawing.Point(249, 147);
            this.textBoxOrderValue.Name = "textBoxOrderValue";
            this.textBoxOrderValue.Size = new System.Drawing.Size(281, 22);
            this.textBoxOrderValue.TabIndex = 2;
            this.textBoxOrderValue.Text = "0";
            this.textBoxOrderValue.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxOrderValue_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Value $ : ";
            // 
            // textBoxOrderSender
            // 
            this.textBoxOrderSender.Location = new System.Drawing.Point(249, 230);
            this.textBoxOrderSender.Name = "textBoxOrderSender";
            this.textBoxOrderSender.Size = new System.Drawing.Size(281, 22);
            this.textBoxOrderSender.TabIndex = 4;
            this.textBoxOrderSender.Text = "Name";
            this.textBoxOrderSender.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxOrderSender_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sender : ";
            // 
            // textBoxOrderDetails
            // 
            this.textBoxOrderDetails.Location = new System.Drawing.Point(249, 315);
            this.textBoxOrderDetails.Name = "textBoxOrderDetails";
            this.textBoxOrderDetails.Size = new System.Drawing.Size(281, 22);
            this.textBoxOrderDetails.TabIndex = 6;
            this.textBoxOrderDetails.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Details : ";
            // 
            // buttonOrderAdd
            // 
            this.buttonOrderAdd.BackColor = System.Drawing.Color.Lime;
            this.buttonOrderAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOrderAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrderAdd.Location = new System.Drawing.Point(249, 370);
            this.buttonOrderAdd.Name = "buttonOrderAdd";
            this.buttonOrderAdd.Size = new System.Drawing.Size(113, 68);
            this.buttonOrderAdd.TabIndex = 8;
            this.buttonOrderAdd.Text = "ADD";
            this.buttonOrderAdd.UseVisualStyleBackColor = false;
            this.buttonOrderAdd.Click += new System.EventHandler(this.buttonOrderAdd_Click);
            // 
            // buttonOrderCancel
            // 
            this.buttonOrderCancel.BackColor = System.Drawing.Color.Red;
            this.buttonOrderCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOrderCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrderCancel.Location = new System.Drawing.Point(417, 370);
            this.buttonOrderCancel.Name = "buttonOrderCancel";
            this.buttonOrderCancel.Size = new System.Drawing.Size(113, 68);
            this.buttonOrderCancel.TabIndex = 9;
            this.buttonOrderCancel.Text = "CANCEL";
            this.buttonOrderCancel.UseVisualStyleBackColor = false;
            // 
            // FormOrder
            // 
            this.AcceptButton = this.buttonOrderAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.buttonOrderCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOrderCancel);
            this.Controls.Add(this.buttonOrderAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxOrderDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOrderSender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOrderValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerOrder);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOrderValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOrderSender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOrderDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOrderAdd;
        private System.Windows.Forms.Button buttonOrderCancel;
    }
}