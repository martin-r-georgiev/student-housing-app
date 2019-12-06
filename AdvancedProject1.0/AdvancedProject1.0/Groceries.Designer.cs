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
            this.lblFirsttoBuy = new System.Windows.Forms.Label();
            this.lblSecondtoBuy = new System.Windows.Forms.Label();
            this.lbGroceries = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirsttoBuy
            // 
            this.lblFirsttoBuy.AutoSize = true;
            this.lblFirsttoBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblFirsttoBuy.Location = new System.Drawing.Point(7, 90);
            this.lblFirsttoBuy.Name = "lblFirsttoBuy";
            this.lblFirsttoBuy.Size = new System.Drawing.Size(59, 25);
            this.lblFirsttoBuy.TabIndex = 0;
            this.lblFirsttoBuy.Text = "John";
            // 
            // lblSecondtoBuy
            // 
            this.lblSecondtoBuy.AutoSize = true;
            this.lblSecondtoBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblSecondtoBuy.Location = new System.Drawing.Point(13, 130);
            this.lblSecondtoBuy.Name = "lblSecondtoBuy";
            this.lblSecondtoBuy.Size = new System.Drawing.Size(53, 18);
            this.lblSecondtoBuy.TabIndex = 1;
            this.lblSecondtoBuy.Text = "Steven";
            // 
            // lbGroceries
            // 
            this.lbGroceries.FormattingEnabled = true;
            this.lbGroceries.Location = new System.Drawing.Point(103, 49);
            this.lbGroceries.Name = "lbGroceries";
            this.lbGroceries.Size = new System.Drawing.Size(150, 251);
            this.lbGroceries.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(209, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(44, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 306);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 432);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbHistory);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbGroceries);
            this.Controls.Add(this.lblSecondtoBuy);
            this.Controls.Add(this.lblFirsttoBuy);
            this.Name = "Groceries";
            this.Text = "Groceries";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirsttoBuy;
        private System.Windows.Forms.Label lblSecondtoBuy;
        private System.Windows.Forms.ListBox lbGroceries;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ListBox lbHistory;
        private System.Windows.Forms.Button btnBack;
    }
}