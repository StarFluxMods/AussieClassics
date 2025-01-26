using System.Collections.Generic;
using AussieClassics.Utilies;
using KitchenData;
using KitchenLib.Customs;

namespace AussieClassics.Customs.Dishes
{
    public class DishMeringue : CustomDish
    {
        public override string UniqueNameID => "DishMeringue";
        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.Meringue;
        public override bool IsUnlockable => false;
    }
}