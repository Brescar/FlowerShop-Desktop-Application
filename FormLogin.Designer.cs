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
            this.SuspendLayout();
            // 
            // userControlLogin1
            // 
            this.userControlLogin1.Location = new System.Drawing.Point(79, 38);
            this.userControlLogin1.Name = "userControlLogin1";
            this.userControlLogin1.Padding = new System.Windows.Forms.Padding(3);
            this.userControlLogin1.Size = new System.Drawing.Size(624, 356);
            this.userControlLogin1.TabIndex = 0;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControlLogin1);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlLogin userControlLogin1;
    }
}