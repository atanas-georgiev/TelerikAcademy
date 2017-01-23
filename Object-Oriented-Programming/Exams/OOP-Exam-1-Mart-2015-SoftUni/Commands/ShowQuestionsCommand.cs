namespace ConsoleForum.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using ConsoleForum.Contracts;
    using ConsoleForum.Entities.Users;
    using ConsoleForum.Utility;

    public class ShowQuestionsCommand : AbstractCommand
    {
        public ShowQuestionsCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            if (this.Forum.Questions.Count == 0)
            {
                throw new CommandException(Messages.NoQuestions);
            }
            else
            {
                foreach (var item in this.Forum.Questions.OrderBy(x => x.Id))
                {
                    Console.WriteLine(item);
                }
                this.Forum.CurrentQuestion = null;
            }
        }
    }
}
