﻿using System.Collections.Generic;
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
    public class KoalaBranch : CustomAppliance
    {
        public override string UniqueNameID => "KoalaBranch";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("KoalaBranch").AssignMaterialsByNames();
        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            new CMustHaveWall(),
            new CKoala()
        };

        public override OccupancyLayer Layer => OccupancyLayer.Wall;
        public override bool IsPurchasable => false;
        public override PriceTier PriceTier => PriceTier.Free;
        public override ShoppingTags ShoppingTags => ShoppingTags.Decoration;
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.KoalaBranch;

        public override void OnRegister(Appliance gameDataObject)
        {
            base.OnRegister(gameDataObject);
            KoalaView koalaView = gameDataObject.Prefab.AddComponent<KoalaView>();
            koalaView.animator = gameDataObject.Prefab.GetComponent<Animator>();
        }
    }
}