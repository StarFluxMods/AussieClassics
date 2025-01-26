using AussieClassics.Customs.Generic;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Appliances
{
    public class OutbackGround : SceneAppliance
    {
        public override string UniqueNameID => "OutbackGround";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("OutbackGround").AssignMaterialsByNames();
    }
}