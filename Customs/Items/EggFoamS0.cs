using AussieClassics.Customs.Generic;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Items
{
    public class EggFoamS0 : GenericStackableItem
    {
        public override string UniqueNameID => "EggFoamS0";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("EggFoamS0").AssignMaterialsByNames();
    }
}