using System.Collections.Generic;
using AussieClassics.Customs.Generic;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Items
{
    public class KiwiFruit : GenericStackableItem
    {
        public override string UniqueNameID => "KiwiFruit";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("KiwiFruit").AssignMaterialsByNames();
        public override Appliance DedicatedProvider => GDOReferences.KiwiFruitProvider;

        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Chop,
                Duration = 1,
                Result = GDOReferences.CutKiwiFruit
            }
        };
    }
}