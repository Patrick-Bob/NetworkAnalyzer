using System.IO;
using System.Net;
using System.Net.Sockets;

namespace NetworkAnalyzer
{
	public static class IPAddress
	{
        public static string GetLocalIP()
        {
            string localIP = string.Empty;

            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();
            }

            return localIP;
        }

		public static string GetPublicIP()
		{
            string message = string.Empty;
            try
            {
                string address = "";
                WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");

                using (WebResponse response = request.GetResponse())
                {
                    using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                    {
                        address = stream.ReadToEnd();
                    }
                }

                int first = address.IndexOf("Address: ") + 9;
                int last = address.LastIndexOf("</body>");
                address = address.Substring(first, last - first);

                message = address;
            }

            catch
            {
                message = "Check your network connection";
            }

            return message;
        }
	}
}
