using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;

    class NetworkingSamples
    {
        static async Task Main30()
        {
            Console.WriteLine("Enter a hostname (e.g. www.google.com): ");
            string hostname = Console.ReadLine();

            // Resolving the hostname to an IP address using DNS
            IPHostEntry hostEntry = Dns.GetHostEntry(hostname);

            Console.WriteLine($"Hostname: {hostname}");
            Console.WriteLine("IP Addresses:");
            foreach (IPAddress ipAddress in hostEntry.AddressList)
            {
                Console.WriteLine(ipAddress);

                if (ipAddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
                    Console.WriteLine("This is an IPv6 Address.");
                else if (ipAddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    Console.WriteLine("This is an IPv4 Address.");
            }

            // Open a socket connection and make a HTTP request
            using HttpClient httpClient = new HttpClient();

            try
            {
                Console.WriteLine($"Making a HTTP request to {hostname}...");
                HttpResponseMessage response = await httpClient.GetAsync($"http://{hostname}");
                Console.WriteLine($"Response status code: {response.StatusCode}");

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Received {responseData.Length} characters.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
            }
        }
    }

}
