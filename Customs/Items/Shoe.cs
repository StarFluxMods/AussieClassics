using AussieClassics.Customs.Generic;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Items
{
    public class Shoe : GenericStackableItem
    {
        public override string UniqueNameID => "Shoe";

        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Shoe").AssignMaterialsByNames();
        // public override Appliance DedicatedProvider => GDOReferences.PassionFruitProvider;
    }
}