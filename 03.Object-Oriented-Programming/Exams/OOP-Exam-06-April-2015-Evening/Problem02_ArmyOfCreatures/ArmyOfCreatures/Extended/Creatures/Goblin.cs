// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Goblin.cs" company="n/a">
//   Atanas Georgiev
// </copyright>
// <summary>
//   The goblin class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;

    /// <summary>
    ///     The goblin.
    /// </summary>
    internal class Goblin : Creature
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Goblin" /> class.
        /// </summary>
        public Goblin()
            : base(4, 2, 5, 1.5m)
        {
        }
    }
}