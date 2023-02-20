namespace clock
{
    partial class Clock
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
            this.clockLabel = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonPink = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.script = new System.Windows.Forms.Button();
            this.sansButton = new System.Windows.Forms.Button();
            this.buttonAlarm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clockLabel
            // 
            this.clockLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLabel.ForeColor = System.Drawing.Color.Red;
            this.clockLabel.Location = new System.Drawing.Point(0, -1);
            this.clockLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clockLabel.MaximumSize = new System.Drawing.Size(675, 731);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(675, 465);
            this.clockLabel.TabIndex = 0;
            this.clockLabel.Text = "...";
            this.clockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clockLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clockLabel_MouseDown);
            // 
            // clockTimer
            // 
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.Green;
            this.buttonGreen.Location = new System.Drawing.Point(12, 439);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(18, 16);
            this.buttonGreen.TabIndex = 1;
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.Location = new System.Drawing.Point(36, 439);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(18, 16);
            this.buttonRed.TabIndex = 2;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonPink
            // 
            this.buttonPink.BackColor = System.Drawing.Color.Pink;
            this.buttonPink.Location = new System.Drawing.Point(60, 439);
            this.buttonPink.Name = "buttonPink";
            this.buttonPink.Size = new System.Drawing.Size(18, 16);
            this.buttonPink.TabIndex = 3;
            this.buttonPink.UseVisualStyleBackColor = false;
            this.buttonPink.Click += new System.EventHandler(this.buttonPink_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonBlue.Location = new System.Drawing.Point(84, 439);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(18, 16);
            this.buttonBlue.TabIndex = 4;
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // script
            // 
            this.script.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.script.Location = new System.Drawing.Point(160, 423);
            this.script.Name = "script";
            this.script.Size = new System.Drawing.Size(81, 32);
            this.script.TabIndex = 5;
            this.script.Text = "Segoe";
            this.script.UseVisualStyleBackColor = true;
            this.script.Click += new System.EventHandler(this.script_Click);
            // 
            // sansButton
            // 
            this.sansButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sansButton.Location = new System.Drawing.Point(247, 423);
            this.sansButton.Name = "sansButton";
            this.sansButton.Size = new System.Drawing.Size(81, 32);
            this.sansButton.TabIndex = 6;
            this.sansButton.Text = "Sans";
            this.sansButton.UseVisualStyleBackColor = true;
            this.sansButton.Click += new System.EventHandler(this.sansButton_Click);
            // 
            // buttonAlarm
            // 
            this.buttonAlarm.Location = new System.Drawing.Point(587, 425);
            this.buttonAlarm.Name = "buttonAlarm";
            this.buttonAlarm.Size = new System.Drawing.Size(78, 30);
            this.buttonAlarm.TabIndex = 7;
            this.buttonAlarm.Text = "Set Alarm";
            this.buttonAlarm.UseVisualStyleBackColor = true;
            this.buttonAlarm.Click += new System.EventHandler(this.buttonAlarm_Click);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 459);
            this.Controls.Add(this.buttonAlarm);
            this.Controls.Add(this.sansButton);
            this.Controls.Add(this.script);
            this.Controls.Add(this.buttonBlue);
            this.Controls.Add(this.buttonPink);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.buttonGreen);
            this.Controls.Add(this.clockLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Clock";
            this.Text = "clock";
            this.Load += new System.EventHandler(this.Clock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonPink;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button script;
        private System.Windows.Forms.Button sansButton;
        private System.Windows.Forms.Button buttonAlarm;
    }
}

