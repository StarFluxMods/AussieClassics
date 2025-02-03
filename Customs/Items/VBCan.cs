using System.Collections.Generic;
using AussieClassics.Customs.Generic;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Items
{
    public class VBCan : GenericStackableItem
    {
        public override string UniqueNameID => "VBCan";

        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("VBCan").AssignMaterialsByNames();
        public override Appliance DedicatedProvider => GDOReferences.VBProvider;
        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Cook,
                Duration = 0.1f,
                Result = GDOReferences.OpenVBCan
            }
        };
    }
}