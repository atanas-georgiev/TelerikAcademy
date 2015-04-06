// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DoubleDamage.cs" company="n/a">
//   Atanas Georgiev
// </copyright>
// <summary>
//   The double damage.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ArmyOfCreatures.Extended.Specialties
{
    using System;

    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic.Specialties;

    /// <summary>
    ///     The double damage.
    /// </summary>
    internal class DoubleDamage : Specialty
    {
        /// <summary>
        ///     The min number of rounds.
        /// </summary>
        private const int MinNumberOfRounds = 1;

        /// <summary>
        ///     The max number of rounds.
        /// </summary>
        private const int MaxNumberOfRounds = 10;

        /// <summary>
        ///     The number of rounds.
        /// </summary>
        private int numberOfRounds;

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleDamage"/> class.
        /// </summary>
        /// <param name="numberOfRounds">
        /// The number of rounds.
        /// </param>
        /// <exception cref="ArgumentException">
        /// </exception>
        public DoubleDamage(int numberOfRounds)
        {
            if (numberOfRounds < MinNumberOfRounds || numberOfRounds > MaxNumberOfRounds)
            {
                throw new ArgumentException(
                    string.Format(
                        "Number of rounds should be between {0} and {1}", 
                        MinNumberOfRounds, 
                        MaxNumberOfRounds));
            }

            this.numberOfRounds = numberOfRounds;
        }

        /// <summary>
        /// The change damage when attacking.
        /// </summary>
        /// <param name="attackerWithSpecialty">
        /// The attacker with specialty.
        /// </param>
        /// <param name="defender">
        /// The defender.
        /// </param>
        /// <param name="currentDamage">
        /// The current damage.
        /// </param>
        /// <returns>
        /// The <see cref="decimal"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// </exception>
        public override decimal ChangeDamageWhenAttacking(
            ICreaturesInBattle attackerWithSpecialty, 
            ICreaturesInBattle defender, 
            decimal currentDamage)
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
                return currentDamage;
            }

            this.numberOfRounds--;
            return 2 * currentDamage;
        }

        /// <summary>
        ///     The to string.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public override string ToString()
        {
            return string.Format("DoubleDamage({0})", this.numberOfRounds);
        }
    }
}