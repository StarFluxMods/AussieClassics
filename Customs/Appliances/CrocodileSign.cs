using System.Collections.Generic;
using AussieClassics.Utilies;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Appliances
{
    public class CrocodileSign : CustomAppliance
    {
        public override string UniqueNameID => "CrocodileSign";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CrocodileSign").AssignMaterialsByNames();
        public override bool IsPurchasable => false;
        public override PriceTier PriceTier => PriceTier.Free;
        public override ShoppingTags ShoppingTags => ShoppingTags.Decoration;
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.CrocodileSign;
    }
}