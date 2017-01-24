// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddAttackWhenSkip.cs" company="n/a">
//   Atanas Georgiev
// </copyright>
// <summary>
//   The add attack when skip.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ArmyOfCreatures.Extended.Specialties
{
    using System;

    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic.Specialties;

    /// <summary>
    ///     The add attack when skip.
    /// </summary>
    internal class AddAttackWhenSkip : Specialty
    {
        /// <summary>
        ///     The min attack add on.
        /// </summary>
        private const int MinAttackAddOn = 1;

        /// <summary>
        ///     The max attack add on.
        /// </summary>
        private const int MaxAttackAddOn = 10;

        /// <summary>
        ///     The permanent attack addon.
        /// </summary>
        private readonly int permanentAttackAddon;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddAttackWhenSkip"/> class.
        /// </summary>
        /// <param name="permanentAttackAddon">
        /// The permanent attack addon.
        /// </param>
        /// <exception cref="ArgumentException">
        /// </exception>
        public AddAttackWhenSkip(int permanentAttackAddon)
        {
            if (permanentAttackAddon < MinAttackAddOn || permanentAttackAddon > MaxAttackAddOn)
            {
                throw new ArgumentException(
                    string.Format("attack value should be between {0} and {1}", MinAttackAddOn, MaxAttackAddOn));
            }

            this.permanentAttackAddon = permanentAttackAddon;
        }

        /// <summary>
        /// The apply on skip.
        /// </summary>
        /// <param name="skipCreature">
        /// The skip creature.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// </exception>
        public override void ApplyOnSkip(ICreaturesInBattle skipCreature)
        {
            if (skipCreature == null)
            {
                throw new ArgumentNullException("skipCreature");
            }

            skipCreature.PermanentAttack += this.permanentAttackAddon;
        }

        /// <summary>
        ///     The to string.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public override string ToString()
        {
            return string.Format("AddAttackWhenSkip({0})", this.permanentAttackAddon);
        }
    }
}