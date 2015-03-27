namespace ConsoleForum.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using ConsoleForum.Contracts;
    using ConsoleForum.Entities.Users;
    using ConsoleForum.Utility;

    public class OpenQuestionCommand : AbstractCommand
    {
        public OpenQuestionCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            int questionId = int.Parse(this.Data[1]);

            if (this.Forum.Questions.Count(x => x.Id == questionId) == 0)
            {
                throw new CommandException(Messages.NoQuestion);
            }
            else
            {
                Question q = (Question)this.Forum.Questions.First(x => x.Id == questionId);
                this.Forum.CurrentQuestion = q;
                this.Forum.Output.AppendLine(q.ToString());
            }
        }
    }
}
