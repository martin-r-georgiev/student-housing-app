namespace AdvancedProject1._0
{
    partial class NotificationSmallLabel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbDesc = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(16, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            this.lblTitle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotificationSmallLabel_MouseClick);
            this.lblTitle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotificationSmallLabel_MouseDoubleClick);
            this.lblTitle.MouseEnter += new System.EventHandler(this.NotificationSmallLabel_MouseEnter);
            this.lblTitle.MouseLeave += new System.EventHandler(this.NotificationSmallLabel_MouseLeave);
            // 
            // lblDesc
            // 
            this.lblDesc.Location = new System.Drawing.Point(16, 29);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(113, 27);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Description";
            this.lblDesc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotificationSmallLabel_MouseClick);
            this.lblDesc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotificationSmallLabel_MouseDoubleClick);
            this.lblDesc.MouseEnter += new System.EventHandler(this.NotificationSmallLabel_MouseEnter);
            this.lblDesc.MouseLeave += new System.EventHandler(this.NotificationSmallLabel_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 60);
            this.panel1.TabIndex = 2;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotificationSmallLabel_MouseClick);
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotificationSmallLabel_MouseDoubleClick);
            this.panel1.MouseEnter += new System.EventHandler(this.NotificationSmallLabel_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.NotificationSmallLabel_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.panel2.Location = new System.Drawing.Point(18, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 1);
            this.panel2.TabIndex = 10;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotificationSmallLabel_MouseClick);
            this.panel2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotificationSmallLabel_MouseDoubleClick);
            this.panel2.MouseEnter += new System.EventHandler(this.NotificationSmallLabel_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.NotificationSmallLabel_MouseLeave);
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(19, 25);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(109, 31);
            this.tbDesc.TabIndex = 11;
            this.tbDesc.Text = "";
            this.tbDesc.Visible = false;
            this.tbDesc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotificationSmallLabel_MouseClick);
            this.tbDesc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotificationSmallLabel_MouseDoubleClick);
            this.tbDesc.MouseEnter += new System.EventHandler(this.NotificationSmallLabel_MouseEnter);
            this.tbDesc.MouseLeave += new System.EventHandler(this.NotificationSmallLabel_MouseLeave);
            // 
            // NotificationSmallLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitle);
            this.Name = "NotificationSmallLabel";
            this.Size = new System.Drawing.Size(132, 60);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotificationSmallLabel_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotificationSmallLabel_MouseDoubleClick);
            this.MouseEnter += new System.EventHandler(this.NotificationSmallLabel_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.NotificationSmallLabel_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox tbDesc;
    }
}
