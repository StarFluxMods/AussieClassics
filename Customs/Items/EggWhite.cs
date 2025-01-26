using System.Collections.Generic;
using AussieClassics.Customs.Generic;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Items
{
    public class EggWhite : GenericStackableItem
    {
        public override string UniqueNameID => "EggWhite";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("EggWhite").AssignMaterialsByNames();

        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Whisk,
                Duration = 1,
                Result = GDOReferences.EggFoamS0
            }
        };
    }
}