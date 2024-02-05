using System;
using System.Diagnostics;
using System.Net;

public class Program
{
    public static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter word " + (i + 1) + ": ");
            string word = Console.ReadLine();

            string query = "https://www.google.com/search?q=define+" + WebUtility.UrlEncode(word);
            Process.Start(new ProcessStartInfo("cmd", $"/c start {query}") { CreateNoWindow = true });
        }
    }
}