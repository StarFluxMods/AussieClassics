using System.Collections.Generic;
using AussieClassics.Customs.Generic;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.ItemGroups
{
    public class CookedPavlovaTin : GenericStackableItem
    {
        public override string UniqueNameID => "CookedPavlovaTin";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CookedPavlovaTin").AssignMaterialsByNames();
        public override Item DisposesTo => GDOReferences.BigCakeTin;

        public override int SplitCount => 1;
        public override Item SplitSubItem => GDOReferences.CookedPavlovaBase;
        public override List<Item> SplitDepletedItems => new List<Item>
        {
            GDOReferences.BigCakeTin
        };

        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Cook,
                Duration = 0.5f,
                Result = GDOReferences.BurnedPavlovaTin
            }
        };
    }
}