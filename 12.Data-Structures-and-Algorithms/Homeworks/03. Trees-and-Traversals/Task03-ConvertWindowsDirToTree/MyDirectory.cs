namespace Task03_ConvertWindowsDirToTree
{
    using System.Collections.Generic;

    public class MyDirectory
    {
        public MyDirectory(string name)
        {
            this.Name = name;
            this.Files = new List<MyFile>();
            this.ChildFolders = new List<MyDirectory>();
        }

        public string Name { get; set; }

        public List<MyFile> Files { get; set; }

        public List<MyDirectory> ChildFolders { get; set; }
    }
}
