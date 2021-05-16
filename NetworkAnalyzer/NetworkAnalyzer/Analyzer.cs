using System;
using System.Windows.Forms;

namespace NetworkAnalyzer
{
    public partial class NetAnalyzer : Form
    {
        public NetAnalyzer()
        {
            InitializeComponent();
        }

        private void Btn_check_Click(object sender, EventArgs e)
        {
            NetworkInfo networkInfo = new NetworkInfo();
            networkInfo.Show();       
        }

        private void Btn_addInfo_Click(object sender, EventArgs e)
        {
            DeviceInfo addionalInfo = new DeviceInfo();
            addionalInfo.Show();
        }

    }
}
