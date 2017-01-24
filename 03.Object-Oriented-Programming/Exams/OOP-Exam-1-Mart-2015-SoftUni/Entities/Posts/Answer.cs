namespace ConsoleForum.Entities.Users
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ConsoleForum.Contracts;
    
    public class Answer : Post, IAnswer
    {
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(string.Format("\n[ Answer ID: {0} ]", this.Id));
            result.Append(string.Format("\nPosted by: {0}", this.Author.Username));            
            result.Append(string.Format("\nAnswer Body: {0}", this.Body));
            result.Append("\n--------------------");
            return result.ToString();
        }
    }
}
