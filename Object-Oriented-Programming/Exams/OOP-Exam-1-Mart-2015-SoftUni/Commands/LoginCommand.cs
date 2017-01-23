namespace ConsoleForum.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using ConsoleForum.Contracts;
    using ConsoleForum.Entities.Users;
    using ConsoleForum.Utility;

    public class LoginCommand : AbstractCommand
    {
        public LoginCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            if (this.Forum.IsLogged)
            {
                throw new CommandException(Messages.AlreadyLoggedIn);
            }

            var users = this.Forum.Users;
            string username = this.Data[1];
            string password = PasswordUtility.Hash(this.Data[2]);
            IUser currentUser;

            if (users.Count == 0)
            {
                throw new CommandException(Messages.InvalidLoginDetails);
            }

            try
            {
                currentUser = users.First(x => string.Compare(x.Username, username, false) == 0);
            }
            catch (InvalidOperationException)
            {
                throw new CommandException(Messages.InvalidLoginDetails);
            }

            if (currentUser.Password != password)
            {
                throw new CommandException(Messages.InvalidLoginDetails);
            }

            this.Forum.CurrentUser = currentUser;

            this.Forum.Output.AppendLine(
                string.Format(Messages.LoginSuccess, username));
        }
    }
}
