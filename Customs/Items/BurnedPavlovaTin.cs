using AussieClassics.Customs.Generic;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.ItemGroups
{
    public class BurnedPavlovaTin : GenericStackableItem
    {
        public override string UniqueNameID => "BurnedPavlovaTin";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("BurnedPavlovaTin").AssignMaterialsByNames();
        public override Item DisposesTo => GDOReferences.BigCakeTin;
    }
}