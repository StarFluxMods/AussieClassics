using AussieClassics.Customs.Generic;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.ItemGroups
{
    public class CutWaferSheet : GenericStackableItem
    {
        public override string UniqueNameID => "CutWaferSheet";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CutWaferSheet").AssignMaterialsByNames();
    }
}