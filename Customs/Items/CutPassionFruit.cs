using System.Collections.Generic;
using AussieClassics.Customs.Generic;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Items
{
    public class CutPassionFruit : GenericStackableItem
    {
        public override string UniqueNameID => "CutPassionFruit";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CutPassionFruit").AssignMaterialsByNames();

        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Chop,
                Duration = 1,
                Result = GDOReferences.MashedPassionFruit
            }
        };
    }
}