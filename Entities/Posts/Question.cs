namespace ConsoleForum.Entities.Users
{
    using System;
    using System.Collections.Generic;    
    using System.Linq;
    using System.Text;
    using ConsoleForum.Contracts;

    public class Question : Post, IQuestion
    {
        private List<IAnswer> answers = new List<IAnswer>();

        public string Title { get; set; }

        public int BestAnwserId { get; set; }

        public IList<IAnswer> Answers
        {
            get { return this.answers; }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(string.Format("[ Question ID: {0} ]", this.Id));
            result.Append(string.Format("\nPosted by: {0}", this.Author.Username));
            result.Append(string.Format("\nQuestion Title: {0}", this.Title));
            result.Append(string.Format("\nQuestion Body: {0}", this.Body));
            result.Append("\n====================");

            if (this.Answers.Count == 0)
            {
                result.Append("\nNo answers");
            }
            else
            {
                result.Append("\nAnswers:");
                if (this.BestAnwserId != 0)
                {
                    var bestAnswer = this.Answers.First(x => x.Id == this.BestAnwserId);
                    result.Append("\n********************");
                    result.Append(bestAnswer);
                    result.Append("\n********************");
                    foreach (var item in this.Answers.OrderBy(x => x.Id))
                    {
                        if (item.Id != this.BestAnwserId)
                        {
                            result.Append(item);
                        }
                    }
                }

                foreach (var item in this.Answers.OrderBy(x => x.Id))
                {
                    result.Append(item);
                }
            }

            return result.ToString();
        }
    }
}
