namespace Task02_TraverseWindowsDirectory
{
    using System;
    using System.IO;

    public class Startup
    {
        private const string DirectoryName = @"C:\Windows";
        private const string SearchPattern = @"*.exe";

        public static void Main()
        {
            TraverseDirectoryTree(new DirectoryInfo(DirectoryName));
        }

        public static void TraverseDirectoryTree(DirectoryInfo root)
        {
            FileInfo[] files = null;
            DirectoryInfo[] directories = null;

            try
            {
                files = root.GetFiles(SearchPattern);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }

            if (files != null)
            {
                foreach (var fi in files)
                {
                    Console.WriteLine(fi.FullName);
                }
            }

            try
            {
                directories = root.GetDirectories();
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }

            if (directories != null)
            {
                foreach (var di in directories)
                {
                    TraverseDirectoryTree(di);
                }
            }
        }
    }    
}
