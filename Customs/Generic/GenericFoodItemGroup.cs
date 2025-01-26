using KitchenData;
using KitchenLib.Customs;

namespace AussieClassics.Customs.Generic
{
    public abstract class GenericFoodItemGroup : CustomItemGroup
    {
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
    }
}