using AussieClassics.Customs.Generic;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Items
{
    public class FairyBreadCut : GenericStackableItem
    {
        public override string UniqueNameID => "FairyBreadCut";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("FairyBreadCut").AssignMaterialsByNames();
    }
}