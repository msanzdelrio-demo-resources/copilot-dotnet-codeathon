using System;
using System.Net;

namespace Challenge3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an IP address (e.g., 192.168.1.1):");
            string input = Console.ReadLine();
            bool isValid = ValidateIPAddress(input);
            Console.WriteLine(isValid ? "Valid IP address" : "Invalid IP address");
        }

        public static bool ValidateIPAddress(string ip)
        {
            IPAddress ipAddress;
            return IPAddress.TryParse(ip, out ipAddress);
        }
    }
}