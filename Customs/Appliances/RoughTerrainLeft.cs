using AussieClassics.Customs.Generic;
using AussieClassics.Views.Local;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Appliances
{
    public class RoughTerrainLeft : SceneAppliance
    {
        public override string UniqueNameID => "RoughTerrainLeft";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RoughTerrainLeft").AssignMaterialsByNames();
    }
}