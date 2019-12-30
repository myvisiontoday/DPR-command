namespace Television
{
    partial class RemoteController
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
            this.powerButton = new System.Windows.Forms.Button();
            this.volumeUpButton = new System.Windows.Forms.Button();
            this.volumeDownButton = new System.Windows.Forms.Button();
            this.channelUpButton = new System.Windows.Forms.Button();
            this.channelDownButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // powerButton
            // 
            this.powerButton.Location = new System.Drawing.Point(65, 42);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(39, 39);
            this.powerButton.TabIndex = 0;
            this.powerButton.Text = "ON/OFF";
            this.powerButton.UseVisualStyleBackColor = true;
            this.powerButton.Click += new System.EventHandler(this.powerButton_Click);
            // 
            // volumeUpButton
            // 
            this.volumeUpButton.Location = new System.Drawing.Point(27, 117);
            this.volumeUpButton.Name = "volumeUpButton";
            this.volumeUpButton.Size = new System.Drawing.Size(37, 35);
            this.volumeUpButton.TabIndex = 1;
            this.volumeUpButton.Text = "+";
            this.volumeUpButton.UseVisualStyleBackColor = true;
            this.volumeUpButton.Click += new System.EventHandler(this.volumeUpButton_Click);
            // 
            // volumeDownButton
            // 
            this.volumeDownButton.Location = new System.Drawing.Point(27, 172);
            this.volumeDownButton.Name = "volumeDownButton";
            this.volumeDownButton.Size = new System.Drawing.Size(37, 35);
            this.volumeDownButton.TabIndex = 2;
            this.volumeDownButton.Text = "-";
            this.volumeDownButton.UseVisualStyleBackColor = true;
            this.volumeDownButton.Click += new System.EventHandler(this.volumeDownButton_Click);
            // 
            // channelUpButton
            // 
            this.channelUpButton.Location = new System.Drawing.Point(97, 117);
            this.channelUpButton.Name = "channelUpButton";
            this.channelUpButton.Size = new System.Drawing.Size(37, 35);
            this.channelUpButton.TabIndex = 3;
            this.channelUpButton.Text = "UP";
            this.channelUpButton.UseVisualStyleBackColor = true;
            this.channelUpButton.Click += new System.EventHandler(this.channelUpButton_Click);
            // 
            // channelDownButton
            // 
            this.channelDownButton.Location = new System.Drawing.Point(97, 172);
            this.channelDownButton.Name = "channelDownButton";
            this.channelDownButton.Size = new System.Drawing.Size(37, 35);
            this.channelDownButton.TabIndex = 4;
            this.channelDownButton.Text = "Down";
            this.channelDownButton.UseVisualStyleBackColor = true;
            this.channelDownButton.Click += new System.EventHandler(this.channelDownButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Volume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Channel";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 304);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.channelDownButton);
            this.Controls.Add(this.channelUpButton);
            this.Controls.Add(this.volumeDownButton);
            this.Controls.Add(this.volumeUpButton);
            this.Controls.Add(this.powerButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.Button volumeUpButton;
        private System.Windows.Forms.Button volumeDownButton;
        private System.Windows.Forms.Button channelUpButton;
        private System.Windows.Forms.Button channelDownButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}