namespace ConsoleForum.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using ConsoleForum.Contracts;
    using ConsoleForum.Entities.Users;
    using ConsoleForum.Utility;

    public class PostAnswerCommand : AbstractCommand
    {
        public PostAnswerCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            if (!this.Forum.IsLogged)
            {
                throw new CommandException(Messages.NotLogged);
            }
            else if (this.Forum.CurrentQuestion == null)
            {
                throw new CommandException(Messages.NoQuestionOpened);
            }
            else
            {
                Answer a = new Answer();
                a.Id = this.Forum.Answers.Count + 1;
                a.Body = this.Data[1];
                a.Author = this.Forum.CurrentUser;
                this.Forum.Answers.Add(a);
                this.Forum.CurrentQuestion.Answers.Add(a);

                this.Forum.Output.AppendLine(string.Format(Messages.PostAnswerSuccess, a.Id));
            }
        }
    }
}
