using System.Collections.Generic;
using AussieClassics.Utilies;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Dishes
{
    public class DishVegemiteToastCheese : CustomDish
    {
        public override string UniqueNameID => "DishVegemiteToastCheese";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Medium;
        public override DishType Type => DishType.Extra;
        public override int Difficulty => 2;

        public override List<string> StartingNameSet => new()
        {
            "Grilled and Thrilled",
            "Cheesed to Meet You",
            "Mighty Melts",
            "Toast My Luck",
            "Ain’t Easy Being Cheesy",
        };

        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.Cheese
        };

        public override HashSet<Process> RequiredProcesses => new()
        {
            GDOReferences.Chop
        };

        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("VegemiteToastCheeseIcon").AssignMaterialsByNames();

        public override HashSet<Dish.IngredientUnlock> IngredientsUnlocks => new HashSet<Dish.IngredientUnlock>
        {
            new Dish.IngredientUnlock
            {
                MenuItem = GDOReferences.PlatedVegemiteToast,
                Ingredient = GDOReferences.CheeseGrated
            }
        };
        
        public override List<Unlock> HardcodedRequirements => new List<Unlock>
        {
            GDOReferences.DishVegemiteToast
        };

        public override bool IsAvailableAsLobbyOption => Mod.ENABLE_ADDITIONAL_LOBBY_DISHES;
        
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.VegemiteToastCheese;
        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.VegemiteToastCheese;
    }
}