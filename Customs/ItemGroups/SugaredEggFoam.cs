using System.Collections.Generic;
using AussieClassics.Customs.Generic;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.ItemGroups
{
    public class SugaredEggFoam : GenericStackableItemGroup
    {
        public override string UniqueNameID => "SugaredEggFoam";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("EggFoamS0").AssignMaterialsByNames();
        public override List<ItemGroup.ItemSet> Sets => new List<ItemGroup.ItemSet>
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.EggFoamS0,
                    GDOReferences.Sugar
                },
                Min = 2,
                Max = 2,
            }
        };

        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Whisk,
                Duration = 1,
                Result = GDOReferences.EggFoamS1
            }
        };
    }
}