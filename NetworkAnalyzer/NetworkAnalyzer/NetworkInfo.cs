using System;
using System.Net;
using System.Windows.Forms;

namespace NetworkAnalyzer
{
	public partial class NetworkInfo : Form
    {
        public NetworkInfo()
        {
            InitializeComponent();
        }

        private void NetworkInfo_Load(object sender, EventArgs e)
        {
            GetNetworkInfo();
        }

        private void GetNetworkInfo()
        {
            lbl_hostname_info.Text = GetHostName();

            lbl_localip_info.Text = IPAddress.GetLocalIP();

            lbl_mac_info.Text = MacAddress.GetMacAddress();

            lbl_public_info.Text = IPAddress.GetPublicIP();
        }

		private string GetHostName() => Dns.GetHostName();

       
    }
}
