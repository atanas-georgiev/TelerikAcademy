namespace ConsoleForum.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using ConsoleForum.Contracts;
    using ConsoleForum.Entities.Users;
    using ConsoleForum.Utility;

    public class MakeBestAnswerCommand : AbstractCommand
    {
        public MakeBestAnswerCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            int answerId = int.Parse(this.Data[1]);

            if (!this.Forum.IsLogged)
            {
                throw new CommandException(Messages.NotLogged);
            }
            else if (this.Forum.CurrentQuestion == null)
            {
                throw new CommandException(Messages.NoQuestionOpened);
            }
            else if (this.Forum.CurrentQuestion.Answers.Count(x => x.Id == answerId) == 0)
            {
                throw new CommandException(Messages.NoAnswer);
            }
            else if (this.Forum.CurrentQuestion.Author != this.Forum.CurrentUser && !(this.Forum.CurrentUser is Administrator))
            {
                throw new CommandException(Messages.NoPermission);
            }
            else
            {
                (this.Forum.CurrentQuestion as Question).BestAnwserId = answerId;
                this.Forum.Output.AppendLine(string.Format(Messages.BestAnswerSuccess, answerId));
            }
        }
    }
}
