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
    public class TimTams : GenericStackableItemGroup
    {
        public override string UniqueNameID => "TimTams";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("TimTams").AssignMaterialsByNames();
        public override bool AutoCollapsing => true;

        public override List<ItemGroup.ItemSet> Sets => new List<ItemGroup.ItemSet>
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.CutWaferSheet,
                    GDOReferences.ChocolateMelted
                },
                Min = 2,
                Max = 2,
                IsMandatory = true
            }
        };

        public override int SplitCount => 5;
        
        public override List<Item> SplitDepletedItems => new List<Item>
        {
            GDOReferences.TimTam
        };
        
        public override Item SplitSubItem => GDOReferences.TimTam;
        
        private static FieldInfo _Objects = ReflectionUtils.GetField<ObjectsSplittableView>("Objects");
        
        public override void OnRegister(ItemGroup gameDataObject)
        {
            base.OnRegister(gameDataObject);

            ObjectsSplittableView objectsSplittableView = gameDataObject.Prefab.AddComponent<ObjectsSplittableView>();

            List<GameObject> Objects = new List<GameObject>
            {
                gameDataObject.Prefab.GetChild("TimTams/CutWafer"),
                gameDataObject.Prefab.GetChild("TimTams/CutWafer.001"),
                gameDataObject.Prefab.GetChild("TimTams/CutWafer.002"),
                gameDataObject.Prefab.GetChild("TimTams/CutWafer.003"),
                gameDataObject.Prefab.GetChild("TimTams/CutWafer.004"),
            };
            
            _Objects.SetValue(objectsSplittableView, Objects);
        }
    }
}