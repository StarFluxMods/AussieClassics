using AussieClassics.Customs.Generic;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Items
{
    public class MashedPassionFruit : GenericStackableItem
    {
        public override string UniqueNameID => "MashedPassionFruit";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("MashedPassionFruit").AssignMaterialsByNames();
    }
}