namespace Task02_Articles
{
    using System;

    public class Article : IComparable
    {
        public Article(string title, string barcode, string vendor)
        {
            this.Title = title;
            this.Barcode = barcode;
            this.Vendor = vendor;
        }

        public string Title { get; set; }

        public string Barcode { get; set; }

        public string Vendor { get; set; }

        public override string ToString()
        {
            return this.Title + " " + this.Barcode + " " + this.Vendor;
        }

        public int CompareTo(object obj)
        {
            // this object always first
            return 1;
        }
    }
}
