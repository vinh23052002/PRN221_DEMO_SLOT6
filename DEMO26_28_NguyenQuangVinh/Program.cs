namespace DEMO26_28_NguyenQuangVinh
{
    using System;
    using System.IO;
    using System.Net;
     class Program
    {
        static void Main(string[] args)
        {
            WebRequest request = WebRequest.Create("https://www.google.com.vn/?hl=vi");

            request.Credentials = CredentialCache.DefaultCredentials;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Console.WriteLine("Status: " + response.StatusDescription);
            Console.WriteLine(new string('*',50));

            Stream dataStram = response.GetResponseStream();

            StreamReader reader = new StreamReader(dataStram);

            string responseFromServer = reader.ReadToEnd();

            Console.WriteLine(responseFromServer);
            Console.WriteLine(new string('*',50) );
            
            reader.Close();
            dataStram.Close();
            response.Close();
        }
    }
}