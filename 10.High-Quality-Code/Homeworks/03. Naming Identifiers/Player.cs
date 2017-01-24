// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Player.cs" company="n/a">
//   Player class
// </copyright>
// <summary>
//   Player class
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MineSweeper
{
    /// <summary>
    ///     The player.
    /// </summary>
    public class Player
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Player" /> class.
        /// </summary>
        public Player()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="points">
        /// The points.
        /// </param>
        public Player(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the points.
        /// </summary>
        public int Points { get; set; }
    }
}