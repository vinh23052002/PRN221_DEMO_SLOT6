namespace DEMO29_28_NguyenQuangVinh
{
    using System.Net;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('*',30));
            var domainEntry = Dns.GetHostEntry("https://shopee.vn/");
            Console.WriteLine(domainEntry.HostName); 
            foreach(var ip in domainEntry.AddressList)
            {
                Console.WriteLine(ip);
            }
            Console.ReadLine();
        }
    }
}