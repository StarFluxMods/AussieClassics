using AussieClassics.Customs.Generic;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Items
{
    public class CutKiwiFruit : GenericStackableItem
    {
        public override string UniqueNameID => "CutKiwiFruit";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CutKiwiFruit").AssignMaterialsByNames();
    }
}