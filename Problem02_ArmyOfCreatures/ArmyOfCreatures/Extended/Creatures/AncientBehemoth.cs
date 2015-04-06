// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AncientBehemoth.cs" company="n/a">
//   Atanas Georgiev
// </copyright>
// <summary>
//   The ancient behemoth class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;

    /// <summary>
    ///     The ancient behemoth.
    /// </summary>
    internal class AncientBehemoth : Creature
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="AncientBehemoth" /> class.
        /// </summary>
        public AncientBehemoth()
            : base(19, 19, 300, 40m)
        {
            this.AddSpecialty(new ReduceEnemyDefenseByPercentage(80));
            this.AddSpecialty(new DoubleDefenseWhenDefending(5));
        }
    }
}