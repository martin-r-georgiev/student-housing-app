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
            this.SuspendLayout();
            // 
            // lblCurrentToBuy
            // 
            this.lblCurrentToBuy.AutoSize = true;
            this.lblCurrentToBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblCurrentToBuy.Location = new System.Drawing.Point(7, 90);
            this.lblCurrentToBuy.Name = "lblCurrentToBuy";
            this.lblCurrentToBuy.Size = new System.Drawing.Size(59, 25);
            this.lblCurrentToBuy.TabIndex = 0;
            this.lblCurrentToBuy.Text = "John";
            // 
            // lblNextToBuy
            // 
            this.lblNextToBuy.AutoSize = true;
            this.lblNextToBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblNextToBuy.Location = new System.Drawing.Point(13, 130);
            this.lblNextToBuy.Name = "lblNextToBuy";
            this.lblNextToBuy.Size = new System.Drawing.Size(53, 18);
            this.lblNextToBuy.TabIndex = 1;
            this.lblNextToBuy.Text = "Steven";
            // 
            // lbGroceries
            // 
            this.lbGroceries.FormattingEnabled = true;
            this.lbGroceries.Location = new System.Drawing.Point(103, 49);
            this.lbGroceries.Name = "lbGroceries";
            this.lbGroceries.Size = new System.Drawing.Size(150, 251);
            this.lbGroceries.TabIndex = 2;
            // 
            // tbAddProduct
            // 
            this.tbAddProduct.Location = new System.Drawing.Point(103, 23);
            this.tbAddProduct.Multiline = true;
            this.tbAddProduct.Name = "tbAddProduct";
            this.tbAddProduct.Size = new System.Drawing.Size(100, 20);
            this.tbAddProduct.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(209, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(44, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // tbPaid
            // 
            this.tbPaid.Location = new System.Drawing.Point(153, 306);
            this.tbPaid.Name = "tbPaid";
            this.tbPaid.Size = new System.Drawing.Size(100, 20);
            this.tbPaid.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "I paid :";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(103, 332);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(150, 37);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // lbHistory
            // 
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.Location = new System.Drawing.Point(288, 49);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(150, 251);
            this.lbHistory.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(49, 43);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Groceries
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 404);
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
            this.Name = "Groceries";
            this.Text = "Groceries";
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
    }
}