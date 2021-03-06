﻿using System;
/*Problem 12. Parse URL

Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and 
extracts from it the [protocol], [server] and [resource] elements.
Example:

URL	Information
http://telerikacademy.com/Courses/Courses/Details/212	[protocol] = http 
[server] = telerikacademy.com 
[resource] = /Courses/Courses/Details/212*/
namespace _12.Parse_URL
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter URL");
            string url = Console.ReadLine();
            int index = 0;
            index = url.IndexOf(':');
            Console.WriteLine("[protocol] = {0}", url.Substring(0, index));
            url = url.Remove(0, index + 3);
            index = url.IndexOf('/');
            Console.WriteLine("[server] = {0}", url.Substring(0, index));
            url = url.Remove(0, index);
            Console.WriteLine("[resource] = {0}", url);
        }
    }
}
