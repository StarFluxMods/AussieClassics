using System.Collections.Generic;
using AussieClassics.Customs.Generic;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.ItemGroups
{
    public class WaferSheet : GenericStackableItem
    {
        public override string UniqueNameID => "WaferSheet";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("WaferSheet").AssignMaterialsByNames();
        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Chop,
                Duration = 0.5f,
                Result = GDOReferences.CutWaferSheet
            }
        };

        public override Appliance DedicatedProvider => GDOReferences.WaferProvider;
    }
}