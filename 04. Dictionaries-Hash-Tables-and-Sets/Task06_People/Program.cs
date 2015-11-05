namespace Task06_People
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Program
    {
        private const string PhonesFileName = "Phones.txt";
        private const string CommandsFileName = "Commands.txt";

        public static void Main()
        {
            string line;
            var phoneData = new List<Person>();
            var commandData = new List<Command>();

            // Parse phone data from the input file
            var file = new StreamReader(PhonesFileName);
            while ((line = file.ReadLine()) != null)
            {
                phoneData.Add(new Person(line));
            }

            // Parse commands data from the input file
            file = new StreamReader(CommandsFileName);
            while ((line = file.ReadLine()) != null)
            {
                commandData.Add(new Command(line));
            }

            // Execute commands
            foreach (var command in commandData)
            {
                var result = CommandExecuter.Execute(command, phoneData);

                Console.WriteLine("Command " + command);

                foreach (var res in result)
                {
                    Console.WriteLine(res);    
                }
            }
        }
    }
}
