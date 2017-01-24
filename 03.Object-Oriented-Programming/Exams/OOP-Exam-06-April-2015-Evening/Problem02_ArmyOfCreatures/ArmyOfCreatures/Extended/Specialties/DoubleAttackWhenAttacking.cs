// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DoubleAttackWhenAttacking.cs" company="n/a">
//   Atanas Georgiev
// </copyright>
// <summary>
//   The double attack when attacking.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ArmyOfCreatures.Extended.Specialties
{
    using System;

    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic.Specialties;

    /// <summary>
    ///     The double attack when attacking.
    /// </summary>
    internal class DoubleAttackWhenAttacking : Specialty
    {
        /// <summary>
        /// The min attack rounds.
        /// </summary>
        private const int MinAttackRounds = 1;

        /// <summary>
        ///     The number of rounds.
        /// </summary>
        private int numberOfRounds;

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleAttackWhenAttacking"/> class.
        /// </summary>
        /// <param name="numberOfRounds">
        /// The number of rounds.
        /// </param>
        /// <exception cref="ArgumentException">
        /// </exception>
        public DoubleAttackWhenAttacking(int numberOfRounds)
        {
            if (numberOfRounds < MinAttackRounds)
            {
                throw new ArgumentException("Number of rounds should be positive");
            }

            this.numberOfRounds = numberOfRounds;
        }

        /// <summary>
        /// The apply when attacking.
        /// </summary>
        /// <param name="attackerWithSpecialty">
        /// The attacker with specialty.
        /// </param>
        /// <param name="defender">
        /// The defender.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// </exception>
        public override void ApplyWhenAttacking(ICreaturesInBattle attackerWithSpecialty, ICreaturesInBattle defender)
        {
            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }

            if (defender == null)
            {
                throw new ArgumentNullException("defender");
            }

            if (this.numberOfRounds <= 0)
            {
                return;
            }

            attackerWithSpecialty.CurrentAttack *= 2;
            this.numberOfRounds--;
        }

        /// <summary>
        ///     The to string.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public override string ToString()
        {
            return string.Format("DoubleAttackWhenAttacking({0})", this.numberOfRounds);
        }
    }
}