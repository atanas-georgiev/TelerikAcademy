// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreaturesFactoryExtended.cs" company="n/a">
//   Atanas Georgiev
// </copyright>
// <summary>
//   The creatures factory extended.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ArmyOfCreatures.Extended
{
    using ArmyOfCreatures.Extended.Creatures;
    using ArmyOfCreatures.Logic;
    using ArmyOfCreatures.Logic.Creatures;

    /// <summary>
    ///     The creatures factory extended.
    /// </summary>
    internal class CreaturesFactoryExtended : CreaturesFactory
    {
        /// <summary>
        /// The create creature.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <returns>
        /// The <see cref="Creature"/>.
        /// </returns>
        public override Creature CreateCreature(string name)
        {
            switch (name)
            {
                case "AncientBehemoth":
                    return new AncientBehemoth();
                case "CyclopsKing":
                    return new CyclopsKing();
                case "Goblin":
                    return new Goblin();
                case "Griffin":
                    return new Griffin();
                case "WolfRaider":
                    return new WolfRaider();
                default:
                    return base.CreateCreature(name);
            }
        }
    }
}