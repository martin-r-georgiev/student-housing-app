namespace AdvancedProject1._0
{
    partial class calendarEventItem
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPlaceholder = new System.Windows.Forms.Label();
            this.contentsPanel = new System.Windows.Forms.Panel();
            this.rightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rightClickMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rightClickMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsPanel.SuspendLayout();
            this.rightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(-2, -7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(10);
            this.lblTitle.Size = new System.Drawing.Size(127, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.FontChanged += new System.EventHandler(this.lblTitle_FontChanged);
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            this.lblTitle.DoubleClick += new System.EventHandler(this.lblTitle_DoubleClick);
            this.lblTitle.MouseEnter += new System.EventHandler(this.lblTitle_MouseEnter);
            this.lblTitle.MouseLeave += new System.EventHandler(this.lblTitle_MouseLeave);
            // 
            // lblPlaceholder
            // 
            this.lblPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlaceholder.AutoEllipsis = true;
            this.lblPlaceholder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlaceholder.Font = new System.Drawing.Font("Open Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceholder.Location = new System.Drawing.Point(-2, -8);
            this.lblPlaceholder.Name = "lblPlaceholder";
            this.lblPlaceholder.Size = new System.Drawing.Size(127, 41);
            this.lblPlaceholder.TabIndex = 1;
            this.lblPlaceholder.Text = " ★";
            this.lblPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlaceholder.Visible = false;
            this.lblPlaceholder.FontChanged += new System.EventHandler(this.lblTitle_FontChanged);
            this.lblPlaceholder.Click += new System.EventHandler(this.lblTitle_Click);
            this.lblPlaceholder.DoubleClick += new System.EventHandler(this.lblTitle_DoubleClick);
            this.lblPlaceholder.MouseEnter += new System.EventHandler(this.lblTitle_MouseEnter);
            this.lblPlaceholder.MouseLeave += new System.EventHandler(this.lblTitle_MouseLeave);
            // 
            // contentsPanel
            // 
            this.contentsPanel.BackColor = System.Drawing.Color.DarkRed;
            this.contentsPanel.Controls.Add(this.lblTitle);
            this.contentsPanel.Controls.Add(this.lblPlaceholder);
            this.contentsPanel.Location = new System.Drawing.Point(3, 3);
            this.contentsPanel.Name = "contentsPanel";
            this.contentsPanel.Size = new System.Drawing.Size(124, 26);
            this.contentsPanel.TabIndex = 2;
            // 
            // rightClickMenu
            // 
            this.rightClickMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rightClickMenuItem1,
            this.rightClickMenuItem2});
            this.rightClickMenu.Name = "contextMenuStrip1";
            this.rightClickMenu.Size = new System.Drawing.Size(197, 52);
            this.rightClickMenu.Opening += new System.ComponentModel.CancelEventHandler(this.rightClickMenu_Opening);
            // 
            // rightClickMenuItem1
            // 
            this.rightClickMenuItem1.Name = "rightClickMenuItem1";
            this.rightClickMenuItem1.Size = new System.Drawing.Size(196, 24);
            this.rightClickMenuItem1.Text = "Mark as complete";
            this.rightClickMenuItem1.Click += new System.EventHandler(this.rightClickMenuItem1_Click);
            // 
            // rightClickMenuItem2
            // 
            this.rightClickMenuItem2.Name = "rightClickMenuItem2";
            this.rightClickMenuItem2.Size = new System.Drawing.Size(196, 24);
            this.rightClickMenuItem2.Text = "Delete event";
            this.rightClickMenuItem2.Click += new System.EventHandler(this.rightClickMenuItem2_Click);
            // 
            // calendarEventItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.Controls.Add(this.contentsPanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "calendarEventItem";
            this.Size = new System.Drawing.Size(130, 32);
            this.SizeChanged += new System.EventHandler(this.calendarEventItem_SizeChanged);
            this.contentsPanel.ResumeLayout(false);
            this.rightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPlaceholder;
        private System.Windows.Forms.Panel contentsPanel;
        private System.Windows.Forms.ContextMenuStrip rightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem rightClickMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rightClickMenuItem2;
    }
}
