using KitchenData;
using KitchenLib.Customs;

namespace AussieClassics.Customs.Generic
{
    public abstract class GenericStackableItem : CustomItem
    {
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
    }
}