using System.Collections.Generic;
using AussieClassics.Customs.RestaurantSettings.Decorators;
using AussieClassics.Utilies;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.RestaurantSettings
{
    public class Outback : CustomRestaurantSetting
    {
        public override string UniqueNameID => "Outback";
        public override WeatherMode WeatherMode => WeatherMode.None;
        public override List<IDecorationConfiguration> Decorators => new List<IDecorationConfiguration>
        {
            new OutbackDecorator.DecorationsConfiguration
            {
                Scatters = new List<OutbackDecorator.DecorationsConfiguration.Scatter>
                {
                    new OutbackDecorator.DecorationsConfiguration.Scatter
                    {
                        Appliance = GDOReferences.OutbackTree,
                        Probability = 0.05f
                    }
                },
                Ground = GDOReferences.OutbackGround,
                IncludeRoad = true
            }
        };
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("OutbackSnowglobe").AssignMaterialsByNames();
        public override List<(Locale, BasicInfo)> InfoList => CenteralLang.RestaurantSettings.Outback;
    }
}