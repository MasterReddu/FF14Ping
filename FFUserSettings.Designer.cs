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
            this.lblDataServer = new System.Windows.Forms.Label();
            this.cmbDataServer = new System.Windows.Forms.ComboBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnShowBack
            // 
            this.btnShowBack.Location = new System.Drawing.Point(15, 138);
            this.btnShowBack.Name = "btnShowBack";
            this.btnShowBack.Size = new System.Drawing.Size(290, 23);
            this.btnShowBack.TabIndex = 0;
            this.btnShowBack.Text = "Save";
            this.btnShowBack.UseVisualStyleBackColor = true;
            this.btnShowBack.Click += new System.EventHandler(this.btnShowBack_Click);
            // 
            // lblBackColor
            // 
            this.lblBackColor.AutoSize = true;
            this.lblBackColor.Location = new System.Drawing.Point(12, 18);
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
            this.cmbBackColor.Location = new System.Drawing.Point(113, 15);
            this.cmbBackColor.Name = "cmbBackColor";
            this.cmbBackColor.Size = new System.Drawing.Size(192, 21);
            this.cmbBackColor.TabIndex = 3;
            // 
            // lblDataServer
            // 
            this.lblDataServer.AutoSize = true;
            this.lblDataServer.Location = new System.Drawing.Point(40, 45);
            this.lblDataServer.Name = "lblDataServer";
            this.lblDataServer.Size = new System.Drawing.Size(67, 13);
            this.lblDataServer.TabIndex = 4;
            this.lblDataServer.Text = "Data Server:";
            // 
            // cmbDataServer
            // 
            this.cmbDataServer.AutoCompleteCustomSource.AddRange(new string[] {
            "Primal",
            "Light",
            "Elemental",
            "Chaos",
            "Gaia",
            "Mana",
            "Aether",
            "Crystal"});
            this.cmbDataServer.FormattingEnabled = true;
            this.cmbDataServer.Location = new System.Drawing.Point(113, 42);
            this.cmbDataServer.Name = "cmbDataServer";
            this.cmbDataServer.Size = new System.Drawing.Size(192, 21);
            this.cmbDataServer.TabIndex = 5;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(66, 72);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(41, 13);
            this.lblServer.TabIndex = 6;
            this.lblServer.Text = "Server:";
            // 
            // cmbServer
            // 
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(113, 69);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(192, 21);
            this.cmbServer.TabIndex = 7;
            // 
            // FFUserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 176);
            this.Controls.Add(this.cmbServer);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.cmbDataServer);
            this.Controls.Add(this.lblDataServer);
            this.Controls.Add(this.cmbBackColor);
            this.Controls.Add(this.lblBackColor);
            this.Controls.Add(this.btnShowBack);
            this.Name = "FFUserSettings";
            this.Text = "FFXIV Ping Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowBack;
        private System.Windows.Forms.Label lblBackColor;
        private System.Windows.Forms.ComboBox cmbBackColor;
        private System.Windows.Forms.Label lblDataServer;
        private System.Windows.Forms.ComboBox cmbDataServer;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.ComboBox cmbServer;
    }
}