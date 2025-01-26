using System.Collections.Generic;
using System.Reflection;
using AussieClassics.Customs.Generic;
using AussieClassics.Utilities;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.ItemGroups
{
    public class CutPavlovaBase : GenericStackableItemGroup
    {
        public override string UniqueNameID => "CutPavlovaBase";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CutPavlovaBase").AssignMaterialsByNames();

        public override int SplitCount => 3;
        public override bool SplitByCopying => true;
        public override Item SplitSubItem => GDOReferences.PavlovaSlice;
        public override List<Item> SplitDepletedItems => new List<Item>
        {
            GDOReferences.PavlovaSlice
        };

        public override bool ApplyProcessesToComponents => true;

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

        private static FieldInfo _Objects = ReflectionUtils.GetField<ObjectsSplittableView>("Objects");
        
        public override void OnRegister(ItemGroup gameDataObject)
        {
            base.OnRegister(gameDataObject);

            ObjectsSplittableView objectsSplittableView = gameDataObject.Prefab.AddComponent<ObjectsSplittableView>();

            List<GameObject> Objects = new List<GameObject>
            {
                gameDataObject.Prefab.GetChild("CutPavlovaBase/Slice1"),
                gameDataObject.Prefab.GetChild("CutPavlovaBase/Slice2"),
                gameDataObject.Prefab.GetChild("CutPavlovaBase/Slice3"),
            };
            
            _Objects.SetValue(objectsSplittableView, Objects);
            
            if (gameDataObject.Prefab.TryGetComponent(out ItemGroupView itemGroupView))
            {
                itemGroupView.ComponentGroups = new List<ItemGroupView.ComponentGroup>
                {
                    new()
                    {
                        Item = GDOReferences.ChoppedStrawberry,
                        Objects = new List<GameObject>
                        {
                            gameDataObject.Prefab.GetChild("CutPavlovaBase/Slice1/Strawberry"),
                            gameDataObject.Prefab.GetChild("CutPavlovaBase/Slice2/Strawberry"),
                            gameDataObject.Prefab.GetChild("CutPavlovaBase/Slice3/Strawberry"),
                            gameDataObject.Prefab.GetChild("CutPavlovaBase/Slice4/Strawberry"),
                        },
                        DrawAll = true
                    },
                    new()
                    {
                        Item = GDOReferences.CutKiwiFruit,
                        Objects = new List<GameObject>
                        {
                            gameDataObject.Prefab.GetChild("CutPavlovaBase/Slice1/KiwiFruit"),
                            gameDataObject.Prefab.GetChild("CutPavlovaBase/Slice2/KiwiFruit"),
                            gameDataObject.Prefab.GetChild("CutPavlovaBase/Slice3/KiwiFruit"),
                            gameDataObject.Prefab.GetChild("CutPavlovaBase/Slice4/KiwiFruit"),
                        },
                        DrawAll = true
                    },
                    new()
                    {
                        Item = GDOReferences.MashedPassionFruit,
                        Objects = new List<GameObject>
                        {
                            gameDataObject.Prefab.GetChild("CutPavlovaBase/Slice1/Passionfruit"),
                            gameDataObject.Prefab.GetChild("CutPavlovaBase/Slice2/Passionfruit"),
                            gameDataObject.Prefab.GetChild("CutPavlovaBase/Slice3/Passionfruit"),
                            gameDataObject.Prefab.GetChild("CutPavlovaBase/Slice4/Passionfruit"),
                        },
                        DrawAll = true
                    }
                };
            }
        }
    }
}