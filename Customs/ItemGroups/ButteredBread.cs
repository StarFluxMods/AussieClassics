using System.Collections.Generic;
using AussieClassics.Customs.Generic;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.ItemGroups
{
    public class ButteredBread : GenericStackableItemGroup
    {
        public override string UniqueNameID => "ButteredBread";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("ButteredBread").AssignMaterialsByNames();
        public override List<ItemGroup.ItemSet> Sets => new List<ItemGroup.ItemSet>
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.BreadSlice,
                    GDOReferences.Butter
                },
                Min = 2,
                Max = 2,
                IsMandatory = true
            }
        };
    }
}