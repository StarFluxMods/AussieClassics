using AussieClassics.Customs.Generic;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Appliances
{
    public class OutbackTree : SceneAppliance
    {
        public override string UniqueNameID => "OutbackTree";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("OutbackTree").AssignMaterialsByNames();
    }
}