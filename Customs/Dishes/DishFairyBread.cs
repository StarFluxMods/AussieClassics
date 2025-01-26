using System.Collections.Generic;
using AussieClassics.Utilies;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Dishes
{
    public class DishFairyBread : CustomDish
    {
        public override string UniqueNameID => "DishFairyBread";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override DishType Type => DishType.Main;
        public override int Difficulty => 1;

        public override List<string> StartingNameSet => new()
        {
            "Sprinkle Me This",
            "Breadazzled!",
            "Butter Believe in Fairies",
            "Once Upon a Slice",
            "Butter & Sparkles",
        };

        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.Plate,
            GDOReferences.Flour,
            GDOReferences.SprinklesBag,
            GDOReferences.Butter,
        };

        public override HashSet<Process> RequiredProcesses => new()
        {
            GDOReferences.Chop,
            GDOReferences.Knead,
            GDOReferences.Clean,
            GDOReferences.RequireOven,
        };

        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("FairyBreadIcon").AssignMaterialsByNames();

        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new Dish.MenuItem
            {
                Item = GDOReferences.PlatedFairyBread,
                Phase = MenuPhase.Main,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static,
                DynamicMenuIngredient = null
            }
        };
        
        public override List<Unlock> HardcodedRequirements => new List<Unlock>
        {
            GDOReferences.DishVegemiteToast
        };

        public override bool IsAvailableAsLobbyOption => Mod.ENABLE_ADDITIONAL_LOBBY_DISHES;
        
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.FairyBread; 
        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.FairyBread;
    }
}