using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Items
{
    public class SprinklesBag : CustomItem
    {
        public override string UniqueNameID => "SprinklesBag";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("SprinklesBag").AssignMaterialsByNames();
        public override Appliance DedicatedProvider => GDOReferences.SprinklesProvider;
    }
}