using System.Collections.Generic;
using AussieClassics.Utilies;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Interfaces;
using KitchenLib.References;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Dishes
{
    public class DishPizzaEgg : CustomDish
    {
        public override string UniqueNameID => "DishPizzaEgg";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Medium;
        public override DishType Type => DishType.Extra;
        public override int Difficulty => 2;

        public override List<string> StartingNameSet => new()
        {
            "Yolk About It",
            "Pizza Ov-Egg-board",
            "A Cracking Good Slice",
            "The Eggceptional Pizza",
            "Over Easy, Over Cheesy",
        };
        
        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.Egg
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
                MenuItem = GDOReferences.PizzaPlated,
                Ingredient = GDOReferences.EggCooked
            }
        };
        
        public override List<Unlock> HardcodedRequirements => new List<Unlock>
        {
            GDOReferences.PizzaBase
        };

        public override bool IsAvailableAsLobbyOption => Mod.ENABLE_ADDITIONAL_LOBBY_DISHES;
        
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.PizzaEgg;
        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.PizzaEgg;
    }
}