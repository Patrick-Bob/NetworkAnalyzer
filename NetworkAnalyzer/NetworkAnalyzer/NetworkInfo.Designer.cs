namespace NetworkAnalyzer
{
    partial class NetworkInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetworkInfo));
            this.lbl_hostname = new System.Windows.Forms.Label();
            this.lbl_ip_local = new System.Windows.Forms.Label();
            this.lbl_mac = new System.Windows.Forms.Label();
            this.lbl_public_ip = new System.Windows.Forms.Label();
            this.top_panel = new System.Windows.Forms.Panel();
            this.lbl_hostname_info = new System.Windows.Forms.Label();
            this.lbl_localip_info = new System.Windows.Forms.Label();
            this.lbl_mac_info = new System.Windows.Forms.Label();
            this.lbl_public_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_hostname
            // 
            this.lbl_hostname.AutoSize = true;
            this.lbl_hostname.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hostname.Location = new System.Drawing.Point(12, 90);
            this.lbl_hostname.Name = "lbl_hostname";
            this.lbl_hostname.Size = new System.Drawing.Size(233, 24);
            this.lbl_hostname.TabIndex = 1;
            this.lbl_hostname.Text = "Local Machine Host Name";
            // 
            // lbl_ip_local
            // 
            this.lbl_ip_local.AutoSize = true;
            this.lbl_ip_local.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ip_local.Location = new System.Drawing.Point(12, 145);
            this.lbl_ip_local.Name = "lbl_ip_local";
            this.lbl_ip_local.Size = new System.Drawing.Size(149, 24);
            this.lbl_ip_local.TabIndex = 3;
            this.lbl_ip_local.Text = "Local IP Address";
            // 
            // lbl_mac
            // 
            this.lbl_mac.AutoSize = true;
            this.lbl_mac.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mac.Location = new System.Drawing.Point(12, 197);
            this.lbl_mac.Name = "lbl_mac";
            this.lbl_mac.Size = new System.Drawing.Size(124, 24);
            this.lbl_mac.TabIndex = 7;
            this.lbl_mac.Text = "MAC Address";
            // 
            // lbl_public_ip
            // 
            this.lbl_public_ip.AutoSize = true;
            this.lbl_public_ip.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_public_ip.Location = new System.Drawing.Point(12, 251);
            this.lbl_public_ip.Name = "lbl_public_ip";
            this.lbl_public_ip.Size = new System.Drawing.Size(157, 24);
            this.lbl_public_ip.TabIndex = 5;
            this.lbl_public_ip.Text = "Public IP Address";
            // 
            // top_panel
            // 
            this.top_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.top_panel.BackColor = System.Drawing.Color.LightBlue;
            this.top_panel.Location = new System.Drawing.Point(3, 2);
            this.top_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(797, 53);
            this.top_panel.TabIndex = 9;
            // 
            // lbl_hostname_info
            // 
            this.lbl_hostname_info.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hostname_info.Location = new System.Drawing.Point(311, 90);
            this.lbl_hostname_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hostname_info.Name = "lbl_hostname_info";
            this.lbl_hostname_info.Size = new System.Drawing.Size(339, 23);
            this.lbl_hostname_info.TabIndex = 10;
            this.lbl_hostname_info.Text = "-";
            // 
            // lbl_localip_info
            // 
            this.lbl_localip_info.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_localip_info.Location = new System.Drawing.Point(311, 145);
            this.lbl_localip_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_localip_info.Name = "lbl_localip_info";
            this.lbl_localip_info.Size = new System.Drawing.Size(339, 23);
            this.lbl_localip_info.TabIndex = 11;
            this.lbl_localip_info.Text = "-";
            // 
            // lbl_mac_info
            // 
            this.lbl_mac_info.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mac_info.Location = new System.Drawing.Point(311, 198);
            this.lbl_mac_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mac_info.Name = "lbl_mac_info";
            this.lbl_mac_info.Size = new System.Drawing.Size(339, 23);
            this.lbl_mac_info.TabIndex = 12;
            this.lbl_mac_info.Text = "-";
            // 
            // lbl_public_info
            // 
            this.lbl_public_info.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_public_info.Location = new System.Drawing.Point(311, 249);
            this.lbl_public_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_public_info.Name = "lbl_public_info";
            this.lbl_public_info.Size = new System.Drawing.Size(339, 23);
            this.lbl_public_info.TabIndex = 13;
            this.lbl_public_info.Text = "-";
            // 
            // NetworkInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_public_info);
            this.Controls.Add(this.lbl_mac_info);
            this.Controls.Add(this.lbl_localip_info);
            this.Controls.Add(this.lbl_hostname_info);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.lbl_public_ip);
            this.Controls.Add(this.lbl_mac);
            this.Controls.Add(this.lbl_ip_local);
            this.Controls.Add(this.lbl_hostname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NetworkInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-";
            this.Load += new System.EventHandler(this.NetworkInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_hostname;
        private System.Windows.Forms.Label lbl_ip_local;
        private System.Windows.Forms.Label lbl_mac;
        private System.Windows.Forms.Label lbl_public_ip;
        private System.Windows.Forms.Panel top_panel;
		private System.Windows.Forms.Label lbl_hostname_info;
		private System.Windows.Forms.Label lbl_localip_info;
		private System.Windows.Forms.Label lbl_mac_info;
		private System.Windows.Forms.Label lbl_public_info;
	}
}