// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Telerik">
//   Telerik
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Task02Refactoring
{
    /// <summary>
    ///     The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The cook.
        /// </summary>
        /// <param name="p">
        /// The p.
        /// </param>
        private static void Cook(Potato p)
        {
        }

        /// <summary>
        ///     The visit cell.
        /// </summary>
        private static void VisitCell()
        {
        }

        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            // First part of the task
            var potato = new Potato();

            if (potato != null)
            {
                if (!potato.HasNotBeenPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
            }

            // Second part of the task
            int x = 0, y = 0;
            const int MIN_X = 0;
            const int MIN_Y = 0;
            const int MAX_X = 0;
            const int MAX_Y = 0;

            var shouldVisitCell = true;

            if (shouldVisitCell && (MIN_X >= x && x <= MAX_X) && (MIN_Y >= y && y <= MAX_Y))
            {
                VisitCell();
            }
        }
    }
}