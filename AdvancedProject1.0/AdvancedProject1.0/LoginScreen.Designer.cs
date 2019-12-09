namespace AdvancedProject1._0
{
    partial class formLogin
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(107, 75);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(162, 22);
            this.tbName.TabIndex = 2;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(107, 129);
            this.tbPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '•';
            this.tbPass.Size = new System.Drawing.Size(162, 22);
            this.tbPass.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(150, 55);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 17);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Username";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(150, 109);
            this.lblPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(69, 17);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(107, 174);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(162, 28);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 252);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formLogin";
            this.Text = "Login Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnLogin;
    }
}

