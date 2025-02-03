using AussieClassics.Customs.Generic;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Items
{
    public class OpenVBCan : GenericStackableItem
    {
        public override string UniqueNameID => "OpenVBCan";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("OpenVBCan").AssignMaterialsByNames();
    }
}