using System.Collections.Generic;
using AussieClassics.Customs.Generic;
using AussieClassics.Utilities;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.ItemGroups
{
    public class VegemiteToast : GenericStackableItemGroup
    {
        public override string UniqueNameID => "VegemiteToast";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("VegemiteToast").AssignMaterialsByNames();
        public override List<ItemGroup.ItemSet> Sets => new List<ItemGroup.ItemSet>
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.BreadToast,
                    GDOReferences.Vegemite
                },
                Min = 2,
                Max = 2,
            },
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.CheeseGrated
                },
                Min = 0,
                Max = 1,
                RequiresUnlock = true
            }
        };public override List<ItemGroupView.ColourBlindLabel> Labels => new List<ItemGroupView.ColourBlindLabel>
        {
            new ItemGroupView.ColourBlindLabel
            {
                Item = GDOReferences.CheeseGrated,
                Text = "C"
            }
        };

        public override void OnRegister(ItemGroup gameDataObject)
        {
            base.OnRegister(gameDataObject);
            
            if (gameDataObject.Prefab.TryGetComponent(out ItemGroupView itemGroupView))
            {
                itemGroupView.ComponentGroups = new List<ItemGroupView.ComponentGroup>
                {
                    new()
                    {
                        Item = GDOReferences.CheeseGrated,
                        GameObject = gameDataObject.Prefab.GetChild("VegemiteToast/Cheese")
                    }
                };
            }
        }
    }
}