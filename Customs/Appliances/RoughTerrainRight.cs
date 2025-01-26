using AussieClassics.Customs.Generic;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Appliances
{
    public class RoughTerrainRight : SceneAppliance
    {
        public override string UniqueNameID => "RoughTerrainRight";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RoughTerrainRight").AssignMaterialsByNames();
    }
}