//Problem 4. Download file

//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;
using System.IO;

namespace Problem04DownloadFile
{
    class DownloadFile
    {
        static void Main()
        {
            Uri fileUrl;
            string onlyFileName;
            string path = Directory.GetCurrentDirectory();
          
            Console.WriteLine("Enter url to the file:");                        
            
            try
            {
                string fullName = Console.ReadLine();
                onlyFileName = fullName.Substring(fullName.LastIndexOf('/'), fullName.Length - fullName.LastIndexOf('/'));
                fileUrl = new Uri(fullName);
            }
            catch
            {
                Console.WriteLine("Invalid URL entered");
                return;
            }            

            using (WebClient client = new WebClient())
            {
                try 
                {
                    client.DownloadFile(fileUrl, path + "\\" + onlyFileName);
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Null value detected");
                }
                catch (WebException)
                {
                    Console.WriteLine("Url not found");
                }
                catch (NotSupportedException)
                {
                    Console.WriteLine("Not supported");
                }               
                finally
                {
                    Console.WriteLine("Finished!");
                }
            }
        }
    }
}
