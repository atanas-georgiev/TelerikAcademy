// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Griffin.cs" company="n/a">
//   Atanas Georgiev
// </copyright>
// <summary>
//   The griffin class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;

    /// <summary>
    ///     The griffin.
    /// </summary>
    internal class Griffin : Creature
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Griffin" /> class.
        /// </summary>
        public Griffin()
            : base(8, 8, 25, 4.5m)
        {
            this.AddSpecialty(new DoubleDefenseWhenDefending(5));
            this.AddSpecialty(new AddDefenseWhenSkip(3));
            this.AddSpecialty(new Hate(typeof(WolfRaider)));
        }
    }
}