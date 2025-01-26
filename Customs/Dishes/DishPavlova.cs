using System.Collections.Generic;
using AussieClassics.Utilies;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Dishes
{
    public class DishPavlova : CustomDish
    {
        public override string UniqueNameID => "DishPavlova";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override DishType Type => DishType.Dessert;
        public override int Difficulty => 4;

        public override List<Dish> AlsoAddRecipes => new List<Dish>
        {
            GDOReferences.DishMeringue
        };

        public override List<string> StartingNameSet => new()
        {
            "Cloud Nine Bites",
            "Whip It Real Good",
            "Pav-liscious Pleasures",
            "Dessert First, Pav Always",
            "A Berry Sweet Idea",
        };

        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.Egg,
            GDOReferences.Sugar,
            GDOReferences.BigCakeTin,
            GDOReferences.PassionFruit,
        };

        public override HashSet<Process> RequiredProcesses => new()
        {
            GDOReferences.Cook,
            GDOReferences.Whisk,
            GDOReferences.Chop,
        };

        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("PavlovaIcon").AssignMaterialsByNames();

        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new Dish.MenuItem
            {
                Item = GDOReferences.PavlovaSlice,
                Phase = MenuPhase.Dessert,
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
        
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.Pavlova; 
        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.Pavlova;
    }
}