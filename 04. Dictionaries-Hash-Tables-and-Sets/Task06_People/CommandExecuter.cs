namespace Task06_People
{
    using System.Collections.Generic;
    using System.Linq;

    public static class CommandExecuter
    {
        public static IEnumerable<Person> Execute(Command command, IEnumerable<Person> data)
        {
            var result = new List<Person>(data);

            if (command.Name != null)
            {
                result = result.Where(x => x.Name.Contains(command.Name)).ToList();
            }

            if (command.Town != null)
            {
                result = result.Where(x => x.Town.Contains(command.Town)).ToList();
            }

            if (command.Tel != null)
            {
                result = result.Where(x => x.Tel.Contains(command.Tel)).ToList();
            }

            return result;
        }
    }
}
