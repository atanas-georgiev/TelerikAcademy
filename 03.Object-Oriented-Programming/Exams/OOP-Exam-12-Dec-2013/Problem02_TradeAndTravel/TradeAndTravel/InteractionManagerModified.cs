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
                    return base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
            }

            return item;
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location location = null;
            switch (locationTypeString)
            {
                case "mine":
                    location = new Mine(locationName);
                    break;
                case "forest":
                    location = new Forest(locationName);
                    break;
                default:
                    return base.CreateLocation(locationTypeString, locationName);
            }
            return location;
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person person = null;
            switch (personTypeString)
            {
                case "merchant":
                    person = new Merchant(personNameString, personLocation);
                    break;
                default:
                    return base.CreatePerson(personTypeString, personNameString, personLocation);
            }
            return person;
        }

        protected override void HandleItemCreation(string itemTypeString, string itemNameString, string itemLocationString)
        {
            base.HandleItemCreation(itemTypeString, itemNameString, itemLocationString);
        }

        protected override void HandleLocationCreation(string locationTypeString, string locationName)
        {
            base.HandleLocationCreation(locationTypeString, locationName);
        }

        protected override void HandlePersonCreation(string personTypeString, string personNameString, string personLocationString)
        {
            base.HandlePersonCreation(personTypeString, personNameString, personLocationString);
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    HandleGatherInteraction(commandWords[2], actor);                    
                    break;
                case "craft":
                    HandleCraftInteraction(commandWords[2], commandWords[3], actor);                    
                    break;                            
                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }
        }

        private void HandleGatherInteraction(string name, Person actor)
        {
            bool isItemFound = false;

            if (actor.Location.LocationType == LocationType.Forest)
            {
                foreach (Item item in actor.ListInventory())
	            {
		            if (item.ItemType == ItemType.Weapon)
                    {
                        isItemFound = true;
                    }
	            }

                if (isItemFound)
                {
                    Item item = null;
                    item = CreateItem("wood", name, actor.Location, item);
                    actor.AddToInventory(item);
                    ownerByItem[item] = actor;
                    strayItemsByLocation[actor.Location].Add(item);
                }
            }
            else if (actor.Location.LocationType == LocationType.Mine)
            {
                foreach (Item item in actor.ListInventory())
                {
                    if (item.ItemType == ItemType.Armor)
                    {
                        isItemFound = true;
                    }
                }

                if (isItemFound)
                {
                    Item item = null;
                    item = CreateItem("iron", name, actor.Location, item);
                    actor.AddToInventory(item);
                    ownerByItem[item] = actor;
                    strayItemsByLocation[actor.Location].Add(item);
                }
            }
        }

        private void HandleCraftInteraction(string type, string name, Person actor)
        {
            bool isItemFound = false;
            bool isItemFound1 = false;

            if (type == "weapon")
            {
                foreach (Item item in actor.ListInventory())
                {
                    if (item.ItemType == ItemType.Iron)
                    {
                        isItemFound = true;
                    }
                    if (item.ItemType == ItemType.Wood)
                    {
                        isItemFound1 = true;
                    }
                }

                if (isItemFound && isItemFound1)
                {
                    Item item = null;
                    item = CreateItem("weapon", name, actor.Location, item);
                    actor.AddToInventory(item);
                    ownerByItem[item] = actor;
                    strayItemsByLocation[actor.Location].Add(item);
                }
            }
            else if (type == "armor")
            {
                foreach (Item item in actor.ListInventory())
                {
                    if (item.ItemType == ItemType.Iron)
                    {
                        isItemFound = true;
                    }
                }

                if (isItemFound)
                {
                    Item item = null;
                    item = CreateItem("armor", name, actor.Location, item);
                    actor.AddToInventory(item);
                    ownerByItem[item] = actor;
                    strayItemsByLocation[actor.Location].Add(item);
                }
            }

        }
    }
}
