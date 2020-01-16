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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cbShowHide = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.ForeColor = System.Drawing.Color.DarkGray;
            this.tbName.Location = new System.Drawing.Point(33, 285);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(279, 26);
            this.tbName.TabIndex = 2;
            this.tbName.Text = "username";
            this.tbName.Enter += new System.EventHandler(this.TbName_Enter);
            this.tbName.Leave += new System.EventHandler(this.TbName_Leave);
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.ForeColor = System.Drawing.Color.DarkGray;
            this.tbPass.Location = new System.Drawing.Point(33, 352);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(279, 26);
            this.tbPass.TabIndex = 3;
            this.tbPass.Text = "password";
            this.tbPass.Enter += new System.EventHandler(this.TbPass_Enter);
            this.tbPass.Leave += new System.EventHandler(this.TbPass_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(105)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Location = new System.Drawing.Point(93, 426);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(193, 50);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cbShowHide
            // 
            this.cbShowHide.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbShowHide.BackColor = System.Drawing.Color.Transparent;
            this.cbShowHide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbShowHide.BackgroundImage")));
            this.cbShowHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cbShowHide.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cbShowHide.FlatAppearance.BorderSize = 0;
            this.cbShowHide.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.cbShowHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.cbShowHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.cbShowHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShowHide.ForeColor = System.Drawing.Color.Transparent;
            this.cbShowHide.Location = new System.Drawing.Point(318, 352);
            this.cbShowHide.Name = "cbShowHide";
            this.cbShowHide.Size = new System.Drawing.Size(30, 30);
            this.cbShowHide.TabIndex = 7;
            this.cbShowHide.UseVisualStyleBackColor = false;
            this.cbShowHide.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 228);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(117, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.panel2.Location = new System.Drawing.Point(33, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 2);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.panel3.Location = new System.Drawing.Point(33, 384);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 2);
            this.panel3.TabIndex = 10;
            // 
            // formLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(384, 497);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.cbShowHide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 536);
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox cbShowHide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

