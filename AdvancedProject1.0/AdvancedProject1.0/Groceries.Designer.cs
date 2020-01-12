namespace AdvancedProject1._0
{
    partial class Groceries
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
            this.lblCurrentToBuy = new System.Windows.Forms.Label();
            this.lblNextToBuy = new System.Windows.Forms.Label();
            this.lbGroceries = new System.Windows.Forms.ListBox();
            this.tbAddProduct = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbPaid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCurrentToBuy
            // 
            this.lblCurrentToBuy.AutoSize = true;
            this.lblCurrentToBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentToBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCurrentToBuy.Location = new System.Drawing.Point(16, 111);
            this.lblCurrentToBuy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentToBuy.Name = "lblCurrentToBuy";
            this.lblCurrentToBuy.Size = new System.Drawing.Size(66, 36);
            this.lblCurrentToBuy.TabIndex = 0;
            this.lblCurrentToBuy.Text = "text";
            // 
            // lblNextToBuy
            // 
            this.lblNextToBuy.AutoSize = true;
            this.lblNextToBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNextToBuy.Location = new System.Drawing.Point(40, 153);
            this.lblNextToBuy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNextToBuy.Name = "lblNextToBuy";
            this.lblNextToBuy.Size = new System.Drawing.Size(39, 24);
            this.lblNextToBuy.TabIndex = 1;
            this.lblNextToBuy.Text = "text";
            // 
            // lbGroceries
            // 
            this.lbGroceries.BackColor = System.Drawing.SystemColors.Window;
            this.lbGroceries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbGroceries.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGroceries.FormattingEnabled = true;
            this.lbGroceries.ItemHeight = 24;
            this.lbGroceries.Location = new System.Drawing.Point(212, 94);
            this.lbGroceries.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbGroceries.Name = "lbGroceries";
            this.lbGroceries.Size = new System.Drawing.Size(213, 288);
            this.lbGroceries.TabIndex = 2;
            this.lbGroceries.DoubleClick += new System.EventHandler(this.lbGroceries_DoubleClick);
            // 
            // tbAddProduct
            // 
            this.tbAddProduct.Location = new System.Drawing.Point(212, 38);
            this.tbAddProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAddProduct.Multiline = true;
            this.tbAddProduct.Name = "tbAddProduct";
            this.tbAddProduct.Size = new System.Drawing.Size(132, 24);
            this.tbAddProduct.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(353, 36);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 28);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // tbPaid
            // 
            this.tbPaid.Location = new System.Drawing.Point(279, 386);
            this.tbPaid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPaid.Name = "tbPaid";
            this.tbPaid.Size = new System.Drawing.Size(132, 22);
            this.tbPaid.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 390);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "I paid :";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(212, 418);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(200, 46);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // lbHistory
            // 
            this.lbHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.ItemHeight = 25;
            this.lbHistory.Location = new System.Drawing.Point(495, 68);
            this.lbHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(551, 329);
            this.lbHistory.TabIndex = 9;
            this.lbHistory.DoubleClick += new System.EventHandler(this.lbHistory_DoubleClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(16, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 38);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Add product:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(208, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Products to buy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Payments to be done:";
            // 
            // Groceries
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 481);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbHistory);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPaid);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbAddProduct);
            this.Controls.Add(this.lbGroceries);
            this.Controls.Add(this.lblNextToBuy);
            this.Controls.Add(this.lblCurrentToBuy);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Groceries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Groceries_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentToBuy;
        private System.Windows.Forms.Label lblNextToBuy;
        private System.Windows.Forms.ListBox lbGroceries;
        private System.Windows.Forms.TextBox tbAddProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbPaid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ListBox lbHistory;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}