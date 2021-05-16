namespace NetworkAnalyzer
{
    partial class NetAnalyzer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetAnalyzer));
            this.btn_network = new System.Windows.Forms.Button();
            this.btn_device_info = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_network
            // 
            this.btn_network.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_network.FlatAppearance.BorderSize = 0;
            this.btn_network.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_network.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_network.Location = new System.Drawing.Point(157, 170);
            this.btn_network.Name = "btn_network";
            this.btn_network.Size = new System.Drawing.Size(215, 60);
            this.btn_network.TabIndex = 0;
            this.btn_network.Text = "Network Information";
            this.btn_network.UseVisualStyleBackColor = false;
            this.btn_network.Click += new System.EventHandler(this.Btn_check_Click);
            // 
            // btn_device_info
            // 
            this.btn_device_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_device_info.FlatAppearance.BorderSize = 0;
            this.btn_device_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_device_info.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_device_info.Location = new System.Drawing.Point(458, 170);
            this.btn_device_info.Name = "btn_device_info";
            this.btn_device_info.Size = new System.Drawing.Size(215, 60);
            this.btn_device_info.TabIndex = 1;
            this.btn_device_info.Text = "Device Information";
            this.btn_device_info.UseVisualStyleBackColor = false;
            this.btn_device_info.Click += new System.EventHandler(this.Btn_addInfo_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Black;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbl_name.Location = new System.Drawing.Point(12, 28);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(385, 52);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Network Analyzer";
            // 
            // NetAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_device_info);
            this.Controls.Add(this.btn_network);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NetAnalyzer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Analyzer";
           // this.Load += new System.EventHandler(this.NetAnalyzer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_network;
        private System.Windows.Forms.Button btn_device_info;
        private System.Windows.Forms.Label lbl_name;
    }
}

