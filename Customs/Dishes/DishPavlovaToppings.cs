using System.Collections.Generic;
using AussieClassics.Utilies;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Dishes
{
    public class DishPavlovaToppings : CustomDish
    {
        public override string UniqueNameID => "DishPavlovaToppings";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Medium;
        public override DishType Type => DishType.Extra;
        public override int Difficulty => 2;

        public override List<string> StartingNameSet => new()
        {
            "Top Me Maybe",
            "Whip It Good",
            "A Berry Fine Idea",
            "Fruits of Whimsy",
            "The Cherry on Top",
        };

        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.Strawberry,
            GDOReferences.KiwiFruit,
        };

        public override HashSet<Process> RequiredProcesses => new()
        {
            GDOReferences.Chop
        };

        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("PavlovaToppingsIcon").AssignMaterialsByNames();

        public override HashSet<Dish.IngredientUnlock> IngredientsUnlocks => new HashSet<Dish.IngredientUnlock>
        {
            new Dish.IngredientUnlock
            {
                MenuItem = GDOReferences.PavlovaSlice,
                Ingredient = GDOReferences.ChoppedStrawberry
            },
            new Dish.IngredientUnlock
            {
                MenuItem = GDOReferences.PavlovaSlice,
                Ingredient = GDOReferences.CutKiwiFruit
            }
        };
        
        public override List<Unlock> HardcodedRequirements => new List<Unlock>
        {
            GDOReferences.DishPavlova
        };

        public override bool IsAvailableAsLobbyOption => Mod.ENABLE_ADDITIONAL_LOBBY_DISHES;
        
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.PavlovaToppings;
        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.PavlovaToppings;
    }
}