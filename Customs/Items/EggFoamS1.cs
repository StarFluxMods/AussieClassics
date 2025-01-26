using AussieClassics.Customs.Generic;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Items
{
    public class EggFoamS1 : GenericStackableItem
    {
        public override string UniqueNameID => "EggFoamS1";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("EggFoamS1").AssignMaterialsByNames();
    }
}