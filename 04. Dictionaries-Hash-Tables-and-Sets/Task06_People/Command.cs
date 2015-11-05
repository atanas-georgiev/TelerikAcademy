namespace Task06_People
{
    using System;
    using System.Linq;

    public class Command
    {
        private string originalCommand;

        public Command(string line)
        {
            this.originalCommand = line;
            var firstIndex = line.IndexOf("(", StringComparison.Ordinal);
            var lastIndex = line.IndexOf(")", StringComparison.Ordinal);

            var commands = line.Substring(firstIndex + 1, lastIndex - firstIndex - 1);
            var commandsSplited = commands.Split(',');

            switch (commandsSplited.Count())
            {
                case 0:
                    return;
                case 1:
                    this.Name = commandsSplited[0].Trim();
                    return;
                case 2:
                    this.Name = commandsSplited[0].Trim();
                    this.Town = commandsSplited[1].Trim();
                    return;
                case 3:
                    this.Name = commandsSplited[0].Trim();
                    this.Town = commandsSplited[1].Trim();
                    this.Tel = commandsSplited[2].Trim();
                    return;
            }
        }

        public string Name { get; private set; }

        public string Town { get; private set; }

        public string Tel { get; private set; }

        public override string ToString()
        {
            return this.originalCommand;
        }
    }
}
