namespace Task03_ConvertWindowsDirToTree
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        private const string DirectoryName = @"c:\windows";
        private const string SearchPattern = @"*.*";

        public static void Main(string[] args)
        {
            var tree = TraverseDirectoryTree(new DirectoryInfo(DirectoryName));
            var size = CalculateSizeWithDfs(tree);

            Console.WriteLine("Size of folder {0} is {1} bytes", DirectoryName, size);
        }

        public static MyDirectory TraverseDirectoryTree(DirectoryInfo root)
        {
            FileInfo[] files = null;
            DirectoryInfo[] directories = null;
            var myDirectory = new MyDirectory(root.Name);

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
                    myDirectory.Files.Add(new MyFile() { Name = fi.Name, Size = fi.Length});
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
                    myDirectory.ChildFolders.Add(TraverseDirectoryTree(di));                    
                }
            }

            return myDirectory;
        }

        private static double CalculateSizeWithDfs(MyDirectory root)
        {
            return root.Files.Sum(x => x.Size) + root.ChildFolders.Sum(dir => CalculateSizeWithDfs(dir));
        }
    }
}
