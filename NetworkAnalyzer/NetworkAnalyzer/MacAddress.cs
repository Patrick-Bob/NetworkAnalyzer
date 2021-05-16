using System.Net.NetworkInformation;

namespace NetworkAnalyzer
{
	public static class MacAddress
	{
        public static string GetMacAddress()
        {
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            string macAddress = string.Empty;

            foreach (NetworkInterface adapter in networkInterfaces)
            {
                if (macAddress == string.Empty)
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    macAddress = adapter.GetPhysicalAddress().ToString();
                }
            }

            return macAddress;
        }
    }
}
