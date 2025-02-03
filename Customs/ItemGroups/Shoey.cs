using System.Collections.Generic;
using AussieClassics.Customs.Generic;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.ItemGroups
{
    public class Shoey : GenericStackableItemGroup
    {
        public override string UniqueNameID => "Shoey";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Shoey").AssignMaterialsByNames();
        public override List<ItemGroup.ItemSet> Sets => new List<ItemGroup.ItemSet>
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.Shoe,
                    GDOReferences.OpenVBCan
                },
                Min = 2,
                Max = 2,
                IsMandatory = true
            }
        };
    }
}