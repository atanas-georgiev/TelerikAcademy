// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BattleManagerExtended.cs" company="n/a">
//   Atanas Georgiev
// </copyright>
// <summary>
//   The battle manager extended.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ArmyOfCreatures.Extended
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using ArmyOfCreatures.Logic;
    using ArmyOfCreatures.Logic.Battles;

    /// <summary>
    ///     The battle manager extended.
    /// </summary>
    internal class BattleManagerExtended : BattleManager
    {
        /// <summary>
        ///     The third army creatures.
        /// </summary>
        private readonly ICollection<ICreaturesInBattle> thirdArmyCreatures;

        /// <summary>
        /// Initializes a new instance of the <see cref="BattleManagerExtended"/> class.
        /// </summary>
        /// <param name="creaturesFactory">
        /// The creatures factory.
        /// </param>
        /// <param name="logger">
        /// The logger.
        /// </param>
        public BattleManagerExtended(ICreaturesFactory creaturesFactory, ILogger logger)
            : base(creaturesFactory, logger)
        {
            this.thirdArmyCreatures = new List<ICreaturesInBattle>();
        }

        /// <summary>
        /// The add creatures by identifier.
        /// </summary>
        /// <param name="creatureIdentifier">
        /// The creature identifier.
        /// </param>
        /// <param name="creaturesInBattle">
        /// The creatures in battle.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// </exception>
        protected override void AddCreaturesByIdentifier(
            CreatureIdentifier creatureIdentifier, 
            ICreaturesInBattle creaturesInBattle)
        {
            if (creatureIdentifier == null)
            {
                throw new ArgumentNullException("creatureIdentifier");
            }

            if (creaturesInBattle == null)
            {
                throw new ArgumentNullException("creaturesInBattle");
            }

            if (creatureIdentifier.ArmyNumber == 3)
            {
                this.thirdArmyCreatures.Add(creaturesInBattle);
            }
            else
            {
                base.AddCreaturesByIdentifier(creatureIdentifier, creaturesInBattle);
            }
        }

        /// <summary>
        /// The get by identifier.
        /// </summary>
        /// <param name="identifier">
        /// The identifier.
        /// </param>
        /// <returns>
        /// The <see cref="ICreaturesInBattle"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// </exception>
        protected override ICreaturesInBattle GetByIdentifier(CreatureIdentifier identifier)
        {
            if (identifier == null)
            {
                throw new ArgumentNullException("identifier");
            }

            if (identifier.ArmyNumber == 3)
            {
                return this.thirdArmyCreatures.FirstOrDefault(x => x.Creature.GetType().Name == identifier.CreatureType);
            }

            return base.GetByIdentifier(identifier);
        }
    }
}