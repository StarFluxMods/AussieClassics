using System.Collections.Generic;
using AussieClassics.Utilies;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Dishes
{
    public class SideTimTam : CustomDish
    {
        public override string UniqueNameID => "SideTimTam";
        public override DishType Type => DishType.Side;
        public override int Difficulty => 1;

        public override List<Dish.MenuItem> ResultingMenuItems => new List<Dish.MenuItem>
        {
            new Dish.MenuItem
            {
                Item = GDOReferences.TimTam,
                Phase = MenuPhase.Side,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static
            }
        };

        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.WaferSheet,
            GDOReferences.Chocolate,
        };

        public override HashSet<Process> RequiredProcesses => new()
        {
            GDOReferences.Chop,
            GDOReferences.Cook,
        };

        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("TimTamsIcon").AssignMaterialsByNames();
        
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        
        public override CardType CardType => CardType.Default;

        public override List<Unlock> HardcodedRequirements => new List<Unlock>
        {
            GDOReferences.DishVegemiteToast
        };

        public override bool IsAvailableAsLobbyOption => Mod.ENABLE_ADDITIONAL_LOBBY_DISHES;
        
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.TimTams;
        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.TimTams;
    }
}