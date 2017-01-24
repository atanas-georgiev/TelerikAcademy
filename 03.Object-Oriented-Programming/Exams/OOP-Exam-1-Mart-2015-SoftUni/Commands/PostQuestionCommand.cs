namespace ConsoleForum.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using ConsoleForum.Contracts;
    using ConsoleForum.Entities.Users;
    using ConsoleForum.Utility;

    public class PostQuestionCommand : AbstractCommand
    {
        public PostQuestionCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            if (!this.Forum.IsLogged)
            {
                throw new CommandException(Messages.NotLogged);
            }
            else
            {
                Question q = new Question();
                q.Id = this.Forum.Questions.Count + 1;
                q.Title = this.Data[1];
                q.Body = string.Empty;
                q.Author = this.Forum.CurrentUser;                

                for (int i = 2; i < Data.Count; i++)
                {
                    q.Body += this.Data[i];

                    if (i != this.Data.Count - 1)
                    {
                        q.Body += " ";
                    }
                }

                this.Forum.CurrentUser.Questions.Add(q);
                this.Forum.Questions.Add(q);

                this.Forum.Output.AppendLine(string.Format(Messages.PostQuestionSuccess, q.Id));
            }
        }
    }
}
