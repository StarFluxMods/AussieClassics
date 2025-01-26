using System.Collections.Generic;
using AussieClassics.Customs.Generic;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.ItemGroups
{
    public class FairyBread : GenericStackableItemGroup
    {
        public override string UniqueNameID => "FairyBread";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("FairyBread").AssignMaterialsByNames();
        public override List<ItemGroup.ItemSet> Sets => new List<ItemGroup.ItemSet>
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.ButteredBread,
                    GDOReferences.SprinklesBag
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
                Process = GDOReferences.Chop,
                Duration = 1,
                Result = GDOReferences.FairyBreadCut
            }
        };
    }
}