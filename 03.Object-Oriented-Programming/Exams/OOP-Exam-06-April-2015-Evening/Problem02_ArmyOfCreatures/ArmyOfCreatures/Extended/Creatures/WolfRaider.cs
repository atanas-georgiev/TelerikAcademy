// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WolfRaider.cs" company="n/a">
//   Atanas Georgiev
// </copyright>
// <summary>
//   The wolf raider class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Extended.Specialties;
    using ArmyOfCreatures.Logic.Creatures;

    /// <summary>
    ///     The wolf raider.
    /// </summary>
    internal class WolfRaider : Creature
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="WolfRaider" /> class.
        /// </summary>
        public WolfRaider()
            : base(8, 5, 10, 3.5m)
        {
            this.AddSpecialty(new DoubleDamage(7));
        }
    }
}