namespace FF14Ping
{
    partial class FFUserSettings
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
            this.btnShowBack = new System.Windows.Forms.Button();
            this.lblBackColor = new System.Windows.Forms.Label();
            this.cmbBackColor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnShowBack
            // 
            this.btnShowBack.Location = new System.Drawing.Point(323, 26);
            this.btnShowBack.Name = "btnShowBack";
            this.btnShowBack.Size = new System.Drawing.Size(129, 23);
            this.btnShowBack.TabIndex = 0;
            this.btnShowBack.Text = "Show Background";
            this.btnShowBack.UseVisualStyleBackColor = true;
            this.btnShowBack.Click += new System.EventHandler(this.btnShowBack_Click);
            // 
            // lblBackColor
            // 
            this.lblBackColor.AutoSize = true;
            this.lblBackColor.Location = new System.Drawing.Point(12, 31);
            this.lblBackColor.Name = "lblBackColor";
            this.lblBackColor.Size = new System.Drawing.Size(95, 13);
            this.lblBackColor.TabIndex = 2;
            this.lblBackColor.Text = "Select Back Color:";
            // 
            // cmbBackColor
            // 
            this.cmbBackColor.FormattingEnabled = true;
            this.cmbBackColor.Items.AddRange(new object[] {
            "Indian Red",
            "Dark Grey",
            "Dark Green"});
            this.cmbBackColor.Location = new System.Drawing.Point(113, 28);
            this.cmbBackColor.Name = "cmbBackColor";
            this.cmbBackColor.Size = new System.Drawing.Size(192, 21);
            this.cmbBackColor.TabIndex = 3;
            // 
            // FFUserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 185);
            this.Controls.Add(this.cmbBackColor);
            this.Controls.Add(this.lblBackColor);
            this.Controls.Add(this.btnShowBack);
            this.Name = "FFUserSettings";
            this.Text = "FFUserSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowBack;
        private System.Windows.Forms.Label lblBackColor;
        private System.Windows.Forms.ComboBox cmbBackColor;
    }
}