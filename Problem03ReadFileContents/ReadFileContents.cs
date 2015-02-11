//Problem 3. Read file contents

//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;

namespace Problem03ReadFileContents
{
    class ReadFileContents
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file name (with full path): ");
            string fileName = Console.ReadLine();

            try 
            {
                Console.WriteLine(File.ReadAllText(fileName));
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid path or file name");
            }   
            catch (PathTooLongException)
            {
                Console.WriteLine("Path is too long");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory not found");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("No access to file");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O error occurred while opening the file");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Path is in an invalid format.");
            }
        }
    }
}
