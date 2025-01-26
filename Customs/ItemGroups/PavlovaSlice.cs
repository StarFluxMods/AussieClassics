using System.Collections.Generic;
using AussieClassics.Customs.Generic;
using AussieClassics.Utilities;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.ItemGroups
{
    public class PavlovaSlice : GenericStackableItemGroup
    {
        public override string UniqueNameID => "PavlovaSlice";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PavlovaSlice").AssignMaterialsByNames();
        
        public override List<ItemGroup.ItemSet> Sets => new List<ItemGroup.ItemSet>
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.CookedPavlovaBase,
                    GDOReferences.MashedPassionFruit,
                },
                Min = 2,
                Max = 2,
                IsMandatory = true
            },
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.CutKiwiFruit,
                    GDOReferences.ChoppedStrawberry
                },
                IsMandatory = false,
                Min = 0,
                Max = 2,
                RequiresUnlock = true
            }
        };

        public override List<ItemGroupView.ColourBlindLabel> Labels => new List<ItemGroupView.ColourBlindLabel>
        {
            new ItemGroupView.ColourBlindLabel
            {
                Item = GDOReferences.CutKiwiFruit,
                Text = "K"
            },
            new ItemGroupView.ColourBlindLabel
            {
                Item = GDOReferences.ChoppedStrawberry,
                Text = "S"
            },
            new ItemGroupView.ColourBlindLabel
            {
                Item = GDOReferences.MashedPassionFruit,
                Text = "P"
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
                        Item = GDOReferences.ChoppedStrawberry,
                        GameObject = gameDataObject.Prefab.GetChild("PavlovaSlice/Strawberry")
                    },
                    new()
                    {
                        Item = GDOReferences.CutKiwiFruit,
                        GameObject = gameDataObject.Prefab.GetChild("PavlovaSlice/KiwiFruit")
                    },
                    new()
                    {
                        Item = GDOReferences.MashedPassionFruit,
                        GameObject = gameDataObject.Prefab.GetChild("PavlovaSlice/Passionfruit")
                    }
                };
            }
        }
    }
}