namespace clock
{
    partial class Alarm
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
            this.submitBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHour = new System.Windows.Forms.TextBox();
            this.tbMins = new System.Windows.Forms.TextBox();
            this.tbSecs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitBTN
            // 
            this.submitBTN.Location = new System.Drawing.Point(12, 99);
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.Size = new System.Drawing.Size(75, 23);
            this.submitBTN.TabIndex = 0;
            this.submitBTN.Text = "Submit";
            this.submitBTN.UseVisualStyleBackColor = true;
            this.submitBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "hour";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "mins";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "sec";
            // 
            // tbHour
            // 
            this.tbHour.Location = new System.Drawing.Point(75, 9);
            this.tbHour.Name = "tbHour";
            this.tbHour.Size = new System.Drawing.Size(100, 20);
            this.tbHour.TabIndex = 4;
            // 
            // tbMins
            // 
            this.tbMins.Location = new System.Drawing.Point(75, 41);
            this.tbMins.Name = "tbMins";
            this.tbMins.Size = new System.Drawing.Size(100, 20);
            this.tbMins.TabIndex = 5;
            // 
            // tbSecs
            // 
            this.tbSecs.Location = new System.Drawing.Point(75, 73);
            this.tbSecs.Name = "tbSecs";
            this.tbSecs.Size = new System.Drawing.Size(100, 20);
            this.tbSecs.TabIndex = 6;
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 159);
            this.Controls.Add(this.tbSecs);
            this.Controls.Add(this.tbMins);
            this.Controls.Add(this.tbHour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitBTN);
            this.Name = "Alarm";
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.Alarm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHour;
        private System.Windows.Forms.TextBox tbMins;
        private System.Windows.Forms.TextBox tbSecs;
    }
}