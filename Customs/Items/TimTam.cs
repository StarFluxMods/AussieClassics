using AussieClassics.Customs.Generic;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.ItemGroups
{
    public class TimTam : GenericStackableItem
    {
        public override string UniqueNameID => "TimTam";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("TimTam").AssignMaterialsByNames();
        public override bool IsMergeableSide => true;
    }
}