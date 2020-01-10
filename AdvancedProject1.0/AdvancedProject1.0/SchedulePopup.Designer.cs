namespace AdvancedProject1._0
{
    partial class SchedulePopup
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
            this.tbGarbage = new System.Windows.Forms.TrackBar();
            this.lblGarbageValue = new System.Windows.Forms.Label();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.lblGarbageDisposal = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbGarbage)).BeginInit();
            this.SuspendLayout();
            // 
            // tbGarbage
            // 
            this.tbGarbage.Location = new System.Drawing.Point(46, 88);
            this.tbGarbage.Maximum = 7;
            this.tbGarbage.Name = "tbGarbage";
            this.tbGarbage.Size = new System.Drawing.Size(282, 56);
            this.tbGarbage.TabIndex = 0;
            this.tbGarbage.ValueChanged += new System.EventHandler(this.tbGarbage_ValueChanged);
            // 
            // lblGarbageValue
            // 
            this.lblGarbageValue.AutoSize = true;
            this.lblGarbageValue.Location = new System.Drawing.Point(180, 127);
            this.lblGarbageValue.Name = "lblGarbageValue";
            this.lblGarbageValue.Size = new System.Drawing.Size(16, 17);
            this.lblGarbageValue.TabIndex = 1;
            this.lblGarbageValue.Text = "0";
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Location = new System.Drawing.Point(43, 36);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(136, 17);
            this.lblFrequency.TabIndex = 2;
            this.lblFrequency.Text = "Frequency per week";
            // 
            // lblGarbageDisposal
            // 
            this.lblGarbageDisposal.AutoSize = true;
            this.lblGarbageDisposal.Location = new System.Drawing.Point(366, 88);
            this.lblGarbageDisposal.Name = "lblGarbageDisposal";
            this.lblGarbageDisposal.Size = new System.Drawing.Size(120, 17);
            this.lblGarbageDisposal.TabIndex = 3;
            this.lblGarbageDisposal.Text = "Garbage disposal";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(183, 392);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(145, 36);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate Schedule";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // SchedulePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblGarbageDisposal);
            this.Controls.Add(this.lblFrequency);
            this.Controls.Add(this.lblGarbageValue);
            this.Controls.Add(this.tbGarbage);
            this.Name = "SchedulePopup";
            this.Text = "SchedulePopup";
            ((System.ComponentModel.ISupportInitialize)(this.tbGarbage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbGarbage;
        private System.Windows.Forms.Label lblGarbageValue;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.Label lblGarbageDisposal;
        private System.Windows.Forms.Button btnGenerate;
    }
}