using System.Collections.Generic;
using AussieClassics.Utilies;
using AussieClassics.Utilities;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Appliances
{
    public class VegemiteProvider : CustomAppliance
    {
        public override string UniqueNameID => "VegemiteProvider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("VegemiteProvider").AssignMaterialsByNames();

        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            new CItemHolder(),
            new CItemProvider
            {
                Available = 1,
                Maximum = 1,
                PreventReturns = true,
                AutoPlaceOnHolder = true,
                Item = GDOReferences.VegemiteJar.ID
            }
        };

        public override bool SellOnlyAsDuplicate => true;
        public override bool IsPurchasable => true;
        public override PriceTier PriceTier => PriceTier.Medium;
        public override ShoppingTags ShoppingTags => ShoppingTags.Cooking | ShoppingTags.Misc;
        
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.VegemiteProvider;

        public override void OnRegister(Appliance gameDataObject)
        {
            base.OnRegister(gameDataObject);
            
            HoldPointContainer holdPointContainer = gameDataObject.Prefab.AddComponent<HoldPointContainer>();
            LimitedItemSourceView limitedItemSourceView = gameDataObject.Prefab.AddComponent<LimitedItemSourceView>();

            holdPointContainer.HoldPoint = gameDataObject.Prefab.GetChild("Counter/HoldPoint").transform;
            
            limitedItemSourceView.HeldItemPosition = gameDataObject.Prefab.GetChild("Counter/HoldPoint").transform;
            limitedItemSourceView.Items = new List<GameObject>
            {
                gameDataObject.Prefab.GetChild("VegemiteJar")
            };
            limitedItemSourceView.DisplayedItems = 1;
        }
    }
}