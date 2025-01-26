using KitchenData;
using KitchenLib.Customs;

namespace AussieClassics.Customs.Generic
{
    public abstract class GenericStackableItemGroup : CustomItemGroup
    {
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
    }
}