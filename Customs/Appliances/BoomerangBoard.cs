using System.Collections.Generic;
using AussieClassics.Components;
using AussieClassics.Utilies;
using AussieClassics.Views;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Appliances
{
    public class BoomerangBoard : CustomAppliance
    {
        public override string UniqueNameID => "BoomerangBoard";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("BoomerangBoard").AssignMaterialsByNames();
        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            new CMustHaveWall()
        };

        public override OccupancyLayer Layer => OccupancyLayer.Wall;
        public override bool IsPurchasable => false;
        public override PriceTier PriceTier => PriceTier.Free;
        public override ShoppingTags ShoppingTags => ShoppingTags.Decoration;
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.BoomerangBoard;
    }
}