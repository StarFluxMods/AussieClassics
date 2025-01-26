using System.Collections.Generic;
using AussieClassics.Utilies;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Dishes
{
    public class DishVegemiteToast : CustomDish
    {
        public override string UniqueNameID => "DishVegemiteToast";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override DishType Type => DishType.Main;
        public override int Difficulty => 2;

        public override List<string> StartingNameSet => new()
        {
            "Toastally Awesome",
            "Bready or Not, Here I Crumb",
            "All About That Spread",
            "Vegemite the Way",
            "Spread the Love",
        };

        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.Plate,
            GDOReferences.Flour,
            GDOReferences.VegemiteJar,
        };

        public override HashSet<Process> RequiredProcesses => new()
        {
            GDOReferences.Chop,
            GDOReferences.Knead,
            GDOReferences.Clean,
            GDOReferences.RequireOven,
        };

        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("VegemiteToastIcon").AssignMaterialsByNames();

        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new Dish.MenuItem
            {
                Item = GDOReferences.PlatedVegemiteToast,
                Phase = MenuPhase.Main,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static,
                DynamicMenuIngredient = null
            }
        };

        public override bool IsAvailableAsLobbyOption => true;
        
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.VegemiteToast; 
        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.VegemiteToast;
    }
}