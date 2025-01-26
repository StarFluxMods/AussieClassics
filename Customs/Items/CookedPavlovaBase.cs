using AussieClassics.Customs.Generic;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.ItemGroups
{
    public class CookedPavlovaBase : GenericStackableItem
    {
        public override string UniqueNameID => "CookedPavlovaBase";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CookedPavlovaBase").AssignMaterialsByNames();
    }
}