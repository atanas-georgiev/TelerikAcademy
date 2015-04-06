// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CyclopsKing.cs" company="n/a">
//   Atanas Georgiev
// </copyright>
// <summary>
//   The cyclops king class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Extended.Specialties;
    using ArmyOfCreatures.Logic.Creatures;

    /// <summary>
    ///     The cyclops king.
    /// </summary>
    internal class CyclopsKing : Creature
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="CyclopsKing" /> class.
        /// </summary>
        public CyclopsKing()
            : base(17, 13, 70, 18)
        {
            this.AddSpecialty(new AddAttackWhenSkip(3));
            this.AddSpecialty(new DoubleAttackWhenAttacking(4));
            this.AddSpecialty(new DoubleDamage(1));
        }
    }
}