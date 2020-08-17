namespace FF14Ping
{
    partial class FFPing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFPing));
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.lblLatency = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLatency
            // 
            this.lblLatency.AutoSize = true;
            this.lblLatency.BackColor = System.Drawing.Color.Transparent;
            this.lblLatency.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatency.Location = new System.Drawing.Point(10, 9);
            this.lblLatency.Name = "lblLatency";
            this.lblLatency.Size = new System.Drawing.Size(81, 24);
            this.lblLatency.TabIndex = 0;
            this.lblLatency.Text = "1000ms";
            this.lblLatency.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FFPing_MouseDown);
            this.lblLatency.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FFPing_MouseMove);
            this.lblLatency.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FFPing_MouseUp);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(103, -1);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(14, 16);
            this.lblExit.TabIndex = 1;
            this.lblExit.Text = "x";
            this.lblExit.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Location = new System.Drawing.Point(103, 27);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(14, 13);
            this.lblSettings.TabIndex = 2;
            this.lblSettings.Text = "o";
            this.lblSettings.Click += new System.EventHandler(this.lblSettings_Click);
            // 
            // FFPing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = global::FF14Ping.Properties.Settings.Default.SavedBackColor;
            this.ClientSize = new System.Drawing.Size(129, 42);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblLatency);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::FF14Ping.Properties.Settings.Default, "SavedBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FFPing";
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.FFPing_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FFPing_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FFPing_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FFPing_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.Label lblLatency;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblSettings;
    }
}

