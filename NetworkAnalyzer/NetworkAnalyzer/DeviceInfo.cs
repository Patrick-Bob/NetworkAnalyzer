using System;
using System.Windows.Forms;

namespace NetworkAnalyzer
{
    public partial class DeviceInfo : Form
    {
        public DeviceInfo()
        {
            InitializeComponent();
        }

      
        private void DeviceInfo_Load(object sender, EventArgs e)
        {
            DisplayMoreInformation();
        }

        private void DisplayMoreInformation()
        {
            
            string DeviceVersion = Environment.OSVersion.Version.ToString();
            lbl_version_info.Text = DeviceVersion;

            string OperatingSystem = Environment.OSVersion.ToString();
           lbl_os_info.Text = OperatingSystem;

            string OperatingVersionPlatform = Environment.OSVersion.Platform.ToString();
           lbl_platform_info.Text = OperatingVersionPlatform;

            int ProcessorCounter = Environment.ProcessorCount;
            lbl_counter_info.Text = ProcessorCounter.ToString();

            bool  Is64Bit = Environment.Is64BitOperatingSystem;
           lbl_64bit_info.Text = Is64Bit.ToString();
            
            bool Is64BitProcess = Environment.Is64BitProcess;
           lbl_64proc_info.Text = Is64BitProcess.ToString();
      
        }
             
    }
}
