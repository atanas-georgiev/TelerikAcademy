namespace Task06_People
{
    using System.Text;

    public class Person
    {
        public Person(string input)
        {                        
            var splitData = input.Split('|');
            this.Name = splitData[0].Trim();
            this.Town = splitData[1].Trim();
            this.Tel = splitData[2].Trim();
        }

        public string Name { get; private set; }

        public string Town { get; private set; }

        public string Tel { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Name = " + this.Name);
            sb.AppendLine("Town = " + this.Town);
            sb.AppendLine("Tel = " + this.Tel);
            sb.AppendLine("----------------------------------");

            return sb.ToString();
        }
    }
}
