namespace ConsoleForum.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using ConsoleForum.Contracts;
    using ConsoleForum.Entities.Users;
    using ConsoleForum.Utility;

    public class ExitCommand : AbstractCommand
    {
        public ExitCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            System.Environment.Exit(1);
        }
    }
}
