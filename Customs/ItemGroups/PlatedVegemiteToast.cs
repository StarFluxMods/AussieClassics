using System.Collections.Generic;
using AussieClassics.Customs.Generic;
using AussieClassics.Utilities;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.ItemGroups
{
    public class PlatedVegemiteToast : GenericPlatedDish
    {
        public override string UniqueNameID => "PlatedVegemiteToast";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PlatedVegemiteToast").AssignMaterialsByNames();
        
        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.Plate,
                    GDOReferences.BreadToast,
                },
                Min = 2,
                Max = 2,
                IsMandatory = true
            },
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.Vegemite,
                },
                Min = 1,
                Max = 1,
                IsMandatory = false
            },
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.CheeseGrated,
                },
                Min = 0,
                Max = 1,
                RequiresUnlock = true
            }
        };

        public override ItemValue ItemValue => ItemValue.Medium;
        
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
                        GameObject = gameDataObject.Prefab.GetChild("VegemiteToast/VegemiteToast/Cheese")
                    },
                    new()
                    {
                        Item = GDOReferences.Vegemite,
                        GameObject = gameDataObject.Prefab.GetChild("VegemiteToast/VegemiteToast/Vegemite")
                    },
                    new()
                    {
                        Item = GDOReferences.BreadToast,
                        GameObject = gameDataObject.Prefab.GetChild("VegemiteToast/VegemiteToast/Toast")
                    }
                };
            }
        }
    }
}