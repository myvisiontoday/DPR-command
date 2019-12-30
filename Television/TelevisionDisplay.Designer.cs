namespace Television
{
    partial class TelevisionDisplay
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.volumeBar = new System.Windows.Forms.ProgressBar();
            this.channelLabel = new System.Windows.Forms.Label();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.volumeLabel);
            this.panel1.Controls.Add(this.channelLabel);
            this.panel1.Controls.Add(this.volumeBar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 420);
            this.panel1.TabIndex = 0;
            this.panel1.BackColorChanged += new System.EventHandler(this.panel1_BackColorChanged);
            // 
            // volumeBar
            // 
            this.volumeBar.Location = new System.Drawing.Point(37, 384);
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(441, 23);
            this.volumeBar.TabIndex = 0;
            this.volumeBar.Value = 20;
            this.volumeBar.SizeChanged += new System.EventHandler(this.volumeBar_SizeChanged);
            // 
            // channelLabel
            // 
            this.channelLabel.AutoSize = true;
            this.channelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channelLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.channelLabel.Location = new System.Drawing.Point(514, 36);
            this.channelLabel.Name = "channelLabel";
            this.channelLabel.Size = new System.Drawing.Size(43, 17);
            this.channelLabel.TabIndex = 1;
            this.channelLabel.Text = "CH 1";
            this.channelLabel.TextChanged += new System.EventHandler(this.channelLabel_TextChanged);
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.volumeLabel.Location = new System.Drawing.Point(514, 384);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(26, 17);
            this.volumeLabel.TabIndex = 2;
            this.volumeLabel.Text = "20";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 449);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "TV";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label channelLabel;
        private System.Windows.Forms.ProgressBar volumeBar;
        private System.Windows.Forms.Label volumeLabel;
    }
}

