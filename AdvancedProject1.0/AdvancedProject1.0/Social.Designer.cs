namespace AdvancedProject1._0
{
    partial class Social
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Social));
            this.lbChat = new System.Windows.Forms.ListBox();
            this.tbChat = new System.Windows.Forms.TextBox();
            this.btnSendChat = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tcChats = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.lbGeneralChat = new System.Windows.Forms.ListBox();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tcChats.SuspendLayout();
            this.tp1.SuspendLayout();
            this.tp2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbChat
            // 
            this.lbChat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbChat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbChat.FormattingEnabled = true;
            this.lbChat.ItemHeight = 20;
            this.lbChat.Location = new System.Drawing.Point(-4, -2);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(705, 464);
            this.lbChat.TabIndex = 0;
            this.lbChat.SelectedIndexChanged += new System.EventHandler(this.LbChat_SelectedIndexChanged);
            // 
            // tbChat
            // 
            this.tbChat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbChat.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbChat.Location = new System.Drawing.Point(48, 632);
            this.tbChat.Multiline = true;
            this.tbChat.Name = "tbChat";
            this.tbChat.Size = new System.Drawing.Size(661, 36);
            this.tbChat.TabIndex = 1;
            // 
            // btnSendChat
            // 
            this.btnSendChat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSendChat.BackgroundImage")));
            this.btnSendChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSendChat.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnSendChat.FlatAppearance.BorderSize = 0;
            this.btnSendChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendChat.Location = new System.Drawing.Point(715, 628);
            this.btnSendChat.Name = "btnSendChat";
            this.btnSendChat.Size = new System.Drawing.Size(38, 38);
            this.btnSendChat.TabIndex = 2;
            this.btnSendChat.UseVisualStyleBackColor = true;
            this.btnSendChat.Click += new System.EventHandler(this.btnSendChat_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(122)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(122)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(12, 24);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 36);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tcChats
            // 
            this.tcChats.Controls.Add(this.tp1);
            this.tcChats.Controls.Add(this.tp2);
            this.tcChats.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tcChats.ImageList = this.imageList1;
            this.tcChats.ItemSize = new System.Drawing.Size(170, 56);
            this.tcChats.Location = new System.Drawing.Point(48, 98);
            this.tcChats.Multiline = true;
            this.tcChats.Name = "tcChats";
            this.tcChats.Padding = new System.Drawing.Point(10, 8);
            this.tcChats.SelectedIndex = 0;
            this.tcChats.Size = new System.Drawing.Size(707, 523);
            this.tcChats.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcChats.TabIndex = 5;
            this.tcChats.SelectedIndexChanged += new System.EventHandler(this.tcChats_SelectedIndexChanged);
            // 
            // tp1
            // 
            this.tp1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tp1.Controls.Add(this.lbGeneralChat);
            this.tp1.ImageKey = "chat.png";
            this.tp1.Location = new System.Drawing.Point(4, 60);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(699, 459);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "General";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // lbGeneralChat
            // 
            this.lbGeneralChat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbGeneralChat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGeneralChat.FormattingEnabled = true;
            this.lbGeneralChat.ItemHeight = 20;
            this.lbGeneralChat.Location = new System.Drawing.Point(-4, -2);
            this.lbGeneralChat.Name = "lbGeneralChat";
            this.lbGeneralChat.Size = new System.Drawing.Size(705, 464);
            this.lbGeneralChat.TabIndex = 6;
            this.lbGeneralChat.SelectedIndexChanged += new System.EventHandler(this.LbGeneralChat_SelectedIndexChanged);
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.lbChat);
            this.tp2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tp2.ImageIndex = 0;
            this.tp2.Location = new System.Drawing.Point(4, 60);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(3);
            this.tp2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tp2.Size = new System.Drawing.Size(699, 459);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "House Unit";
            this.tp2.UseVisualStyleBackColor = true;
            this.tp2.Click += new System.EventHandler(this.Tp2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "167178_home-icon-png-white (1).png");
            this.imageList1.Images.SetKeyName(1, "chat.png");
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 82);
            this.panel1.TabIndex = 11;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(54, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(157, 65);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Social";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.panel2.Location = new System.Drawing.Point(52, 662);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 2);
            this.panel2.TabIndex = 10;
            // 
            // Social
            // 
            this.AcceptButton = this.btnSendChat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(803, 680);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tcChats);
            this.Controls.Add(this.btnSendChat);
            this.Controls.Add(this.tbChat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Social";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Social";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Social_FormClosing);
            this.Load += new System.EventHandler(this.Social_Load);
            this.tcChats.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.tp2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbChat;
        private System.Windows.Forms.TextBox tbChat;
        private System.Windows.Forms.Button btnSendChat;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabControl tcChats;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.TabPage tp2;
        private System.Windows.Forms.ListBox lbGeneralChat;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
    }
}