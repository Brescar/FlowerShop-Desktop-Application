namespace FlowerShop
{
    partial class FormDelivery
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
            this.buttonDeliveryCancel = new System.Windows.Forms.Button();
            this.buttonDeliveryAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDeliveryDetails = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDeliverySender = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDeliveryValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDelivery = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonDeliveryCancel
            // 
            this.buttonDeliveryCancel.BackColor = System.Drawing.Color.Red;
            this.buttonDeliveryCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonDeliveryCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeliveryCancel.Location = new System.Drawing.Point(443, 355);
            this.buttonDeliveryCancel.Name = "buttonDeliveryCancel";
            this.buttonDeliveryCancel.Size = new System.Drawing.Size(113, 68);
            this.buttonDeliveryCancel.TabIndex = 19;
            this.buttonDeliveryCancel.Text = "CANCEL";
            this.buttonDeliveryCancel.UseVisualStyleBackColor = false;
            // 
            // buttonDeliveryAdd
            // 
            this.buttonDeliveryAdd.BackColor = System.Drawing.Color.Lime;
            this.buttonDeliveryAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonDeliveryAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeliveryAdd.Location = new System.Drawing.Point(275, 355);
            this.buttonDeliveryAdd.Name = "buttonDeliveryAdd";
            this.buttonDeliveryAdd.Size = new System.Drawing.Size(113, 68);
            this.buttonDeliveryAdd.TabIndex = 18;
            this.buttonDeliveryAdd.Text = "ADD";
            this.buttonDeliveryAdd.UseVisualStyleBackColor = false;
            this.buttonDeliveryAdd.Click += new System.EventHandler(this.buttonDeliveryAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Details : ";
            // 
            // textBoxDeliveryDetails
            // 
            this.textBoxDeliveryDetails.Location = new System.Drawing.Point(275, 300);
            this.textBoxDeliveryDetails.Name = "textBoxDeliveryDetails";
            this.textBoxDeliveryDetails.Size = new System.Drawing.Size(281, 22);
            this.textBoxDeliveryDetails.TabIndex = 16;
            this.textBoxDeliveryDetails.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Recipient : ";
            // 
            // textBoxDeliverySender
            // 
            this.textBoxDeliverySender.Location = new System.Drawing.Point(275, 215);
            this.textBoxDeliverySender.Name = "textBoxDeliverySender";
            this.textBoxDeliverySender.Size = new System.Drawing.Size(281, 22);
            this.textBoxDeliverySender.TabIndex = 14;
            this.textBoxDeliverySender.Text = "Name";
            this.textBoxDeliverySender.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDeliverySender_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Value $ : ";
            // 
            // textBoxDeliveryValue
            // 
            this.textBoxDeliveryValue.Location = new System.Drawing.Point(275, 132);
            this.textBoxDeliveryValue.Name = "textBoxDeliveryValue";
            this.textBoxDeliveryValue.Size = new System.Drawing.Size(281, 22);
            this.textBoxDeliveryValue.TabIndex = 12;
            this.textBoxDeliveryValue.Text = "0";
            this.textBoxDeliveryValue.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDeliveryValue_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date due : ";
            // 
            // dateTimePickerDelivery
            // 
            this.dateTimePickerDelivery.Location = new System.Drawing.Point(275, 45);
            this.dateTimePickerDelivery.MinDate = new System.DateTime(2023, 4, 24, 0, 0, 0, 0);
            this.dateTimePickerDelivery.Name = "dateTimePickerDelivery";
            this.dateTimePickerDelivery.Size = new System.Drawing.Size(281, 22);
            this.dateTimePickerDelivery.TabIndex = 10;
            this.dateTimePickerDelivery.Value = new System.DateTime(2023, 4, 24, 19, 30, 11, 0);
            this.dateTimePickerDelivery.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePickerDelivery_Validating);
            // 
            // FormDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeliveryCancel);
            this.Controls.Add(this.buttonDeliveryAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDeliveryDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDeliverySender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDeliveryValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDelivery);
            this.Name = "FormDelivery";
            this.Text = "FormDelivery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeliveryCancel;
        private System.Windows.Forms.Button buttonDeliveryAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDeliveryDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDeliverySender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDeliveryValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDelivery;
    }
}