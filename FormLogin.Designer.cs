namespace FlowerShop
{
    partial class FormLogin
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
            this.userControlLogin1 = new FlowerShop.UserControlLogin();
            this.labelCredentials = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userControlLogin1
            // 
            this.userControlLogin1.Location = new System.Drawing.Point(59, 31);
            this.userControlLogin1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlLogin1.Name = "userControlLogin1";
            this.userControlLogin1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlLogin1.Size = new System.Drawing.Size(468, 289);
            this.userControlLogin1.TabIndex = 0;
            // 
            // labelCredentials
            // 
            this.labelCredentials.AutoSize = true;
            this.labelCredentials.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredentials.Location = new System.Drawing.Point(125, 31);
            this.labelCredentials.Name = "labelCredentials";
            this.labelCredentials.Size = new System.Drawing.Size(357, 39);
            this.labelCredentials.TabIndex = 1;
            this.labelCredentials.Text = "Enter Credentials : ";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.labelCredentials);
            this.Controls.Add(this.userControlLogin1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlLogin userControlLogin1;
        private System.Windows.Forms.Label labelCredentials;
    }
}