using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    class InteractionManagerModified : InteractionManager
    {
        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "armor":
                    item = new Armor(itemNameString, itemLocation);
                    break;
                case "weapon":
                    item = new Weapon(itemNameString, itemLocation);
                    break;
                case "wood":
                    item = new Wood(itemNameString, itemLocation);
                    break;
                case "iron":
                    item = new Iron(itemNameString, itemLocation);
                    break;
                default:
                    break;
            }
            return item;
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location location = null;
            switch (locationTypeString)
            {
                case "town":
                    location = new Town(locationName);
                    break;
                case "mine":
                    location = new Mine(locationName);
                    break;
                case "forest":
                    location = new Forest(locationName);
                    break;
                default:
                    break;
            }
            return location;
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {

            switch (commandWords[1])
            {
                case "gather":
                    HandleGatherInteraction(actor);
                    break;
                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }
        }

        private void HandleGatherInteraction(Person actor)
        {
            switch (actor.Location.LocationType)
            {
                case LocationType.Forest:
                    bool hasWeapon = false;
                    foreach (var item in actor.ListInventory())
                    {
                        if (item.ItemType == ItemType.Weapon)
                        {
                            hasWeapon = true;                            
                        }
                    }

                    if (hasWeapon)
                    {
                        actor.
                    }


                    break;
                default:
                    break;

            }

            foreach (var item in actor.ListInventory())
            {
                if (ownerByItem[item] == actor)
                {
                    strayItemsByLocation[actor.Location].Add(item);
                    this.RemoveFromPerson(actor, item);

                    item.UpdateWithInteraction("drop");
                }
            }
        }
    }
}
