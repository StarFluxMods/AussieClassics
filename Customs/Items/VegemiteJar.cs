using System.Collections.Generic;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Items
{
    public class VegemiteJar : CustomItem
    {
        public override string UniqueNameID => "VegemiteJar";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("VegemiteJar").AssignMaterialsByNames();

        public override Item SplitSubItem => GDOReferences.Vegemite;
        public override List<Item> SplitDepletedItems => new List<Item>
        {
            GDOReferences.Vegemite
        };

        public override int SplitCount => 999;
        public override float SplitSpeed => 1;
        public override bool AllowSplitMerging => true;
        public override bool PreventExplicitSplit => true;
        public override Appliance DedicatedProvider => GDOReferences.VegemiteProvider;
    }
}