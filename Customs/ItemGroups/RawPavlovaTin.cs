using System.Collections.Generic;
using AussieClassics.Customs.Generic;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.ItemGroups
{
    public class RawPavlovaTin : GenericStackableItemGroup
    {
        public override string UniqueNameID => "RawPavlovaTin";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RawPavlovaTin").AssignMaterialsByNames();
        public override Item DisposesTo => GDOReferences.BigCakeTin;
        public override List<ItemGroup.ItemSet> Sets => new List<ItemGroup.ItemSet>
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.BigCakeTin,
                    GDOReferences.EggFoamS1
                },
                Min = 2,
                Max = 2,
                IsMandatory = true
            }
        };

        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Cook,
                Duration = 2,
                Result = GDOReferences.CookedPavlovaTin
            }
        };
    }
}