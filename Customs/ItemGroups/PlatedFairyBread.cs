using System.Collections.Generic;
using AussieClassics.Customs.Generic;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.ItemGroups
{
    public class PlatedFairyBread : GenericPlatedDish
    {
        public override string UniqueNameID => "PlatedFairyBread";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PlatedFairyBread").AssignMaterialsByNames();
        
        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.Plate,
                    GDOReferences.FairyBreadCut
                },
                Min = 2,
                Max = 2,
                IsMandatory = true
            }
        };

        public override ItemValue ItemValue => ItemValue.Small;
    }
}