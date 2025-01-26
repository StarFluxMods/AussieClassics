using System.Collections.Generic;
using AussieClassics.Customs.Generic;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Items
{
    public class PassionFruit : GenericStackableItem
    {
        public override string UniqueNameID => "PassionFruit";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PassionFruit").AssignMaterialsByNames();
        public override Appliance DedicatedProvider => GDOReferences.PassionFruitProvider;

        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Chop,
                Duration = 1,
                Result = GDOReferences.CutPassionFruit
            }
        };
    }
}