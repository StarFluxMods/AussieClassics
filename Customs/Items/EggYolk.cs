using AussieClassics.Customs.Generic;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Items
{
    public class EggYolk : GenericStackableItem
    {
        public override string UniqueNameID => "EggYolk";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("EggYolk").AssignMaterialsByNames();
    }
}