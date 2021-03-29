namespace RPM
{
    partial class ExtraForm
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
            this.HolName = new System.Windows.Forms.Label();
            this.TimeLeft = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // HolName
            // 
            this.HolName.AutoSize = true;
            this.HolName.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HolName.ForeColor = System.Drawing.Color.Crimson;
            this.HolName.Location = new System.Drawing.Point(12, 9);
            this.HolName.Name = "HolName";
            this.HolName.Size = new System.Drawing.Size(134, 33);
            this.HolName.TabIndex = 0;
            this.HolName.Text = "Праздник";
            this.HolName.Click += new System.EventHandler(this.HolName_Click);
            // 
            // TimeLeft
            // 
            this.TimeLeft.AutoSize = true;
            this.TimeLeft.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Italic);
            this.TimeLeft.ForeColor = System.Drawing.Color.Crimson;
            this.TimeLeft.Location = new System.Drawing.Point(12, 55);
            this.TimeLeft.Name = "TimeLeft";
            this.TimeLeft.Size = new System.Drawing.Size(90, 33);
            this.TimeLeft.TabIndex = 1;
            this.TimeLeft.Text = "Время";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ExtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(554, 260);
            this.Controls.Add(this.TimeLeft);
            this.Controls.Add(this.HolName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ExtraForm";
            this.Text = "Счетчик";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExtraForm_FormClosed);
            this.Load += new System.EventHandler(this.ExtraForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HolName;
        private System.Windows.Forms.Label TimeLeft;
        private System.Windows.Forms.Timer timer1;
    }
}