using AussieClassics.Customs.Appliances;
using AussieClassics.Customs.Dishes;
using AussieClassics.Customs.ItemGroups;
using AussieClassics.Customs.Items;
using AussieClassics.Customs.Processes;
using AussieClassics.Customs.RestaurantSettings;
using IngredientLib.Ingredient.Items;
using KitchenData;
using KitchenLib.References;
using KitchenLib.Utils;

namespace AussieClassics.Utilities
{
    public static class GDOReferences
    {
        #region IngredientLib

        #region Items

        public static Item Strawberry => (Item)GDOUtils.GetCustomGameDataObject<Strawberry>().GameDataObject;
        public static Item ChoppedStrawberry => (Item)GDOUtils.GetCustomGameDataObject<ChoppedStrawberry>().GameDataObject;

        #endregion

        #endregion


        #region Vanilla

        #region Process

        public static Process Cook => (Process)GDOUtils.GetExistingGDO(ProcessReferences.Cook);
        public static Process Chop => (Process)GDOUtils.GetExistingGDO(ProcessReferences.Chop);
        public static Process Knead => (Process)GDOUtils.GetExistingGDO(ProcessReferences.Knead);
        public static Process Clean => (Process)GDOUtils.GetExistingGDO(ProcessReferences.Clean);
        public static Process RequireOven => (Process)GDOUtils.GetExistingGDO(ProcessReferences.RequireOven);

        #endregion

        #region Item

        public static Item Egg => (Item)GDOUtils.GetExistingGDO(ItemReferences.Egg);
        public static Item BreadToast => (Item)GDOUtils.GetExistingGDO(ItemReferences.BreadToast);
        public static Item BreadSlice => (Item)GDOUtils.GetExistingGDO(ItemReferences.BreadSlice);
        public static Item Butter => (Item)GDOUtils.GetExistingGDO(ItemReferences.Butter);
        public static Item Sugar => (Item)GDOUtils.GetExistingGDO(ItemReferences.Sugar);
        public static Item CheeseGrated => (Item)GDOUtils.GetExistingGDO(ItemReferences.CheeseGrated);
        public static Item Cheese => (Item)GDOUtils.GetExistingGDO(ItemReferences.Cheese);
        public static Item Plate => (Item)GDOUtils.GetExistingGDO(ItemReferences.Plate);
        public static Item Flour => (Item)GDOUtils.GetExistingGDO(ItemReferences.Flour);
        public static Item PlateDirty => (Item)GDOUtils.GetExistingGDO(ItemReferences.PlateDirty);
        public static Item BigCakeTin => (Item)GDOUtils.GetExistingGDO(ItemReferences.BigCakeTin);

        #endregion

        #region Appliance

        public static Appliance Countertop => (Appliance)GDOUtils.GetExistingGDO(ApplianceReferences.Countertop);
        public static Appliance Mixer => (Appliance)GDOUtils.GetExistingGDO(ApplianceReferences.Mixer);
        public static Appliance WallpaperApplicator => (Appliance)GDOUtils.GetExistingGDO(ApplianceReferences.WallpaperApplicator);
        public static Appliance FlooringApplicator => (Appliance)GDOUtils.GetExistingGDO(ApplianceReferences.FlooringApplicator);

        #endregion

        #endregion

        #region RestaurantSetting

        public static RestaurantSetting Outback => (RestaurantSetting)GDOUtils.GetCustomGameDataObject<Outback>().GameDataObject;

        #endregion

        #region Process

        public static Process Whisk => (Process)GDOUtils.GetCustomGameDataObject<Whisk>().GameDataObject;

        #endregion
        

        #region Item

        public static Item CutKiwiFruit => (Item)GDOUtils.GetCustomGameDataObject<CutKiwiFruit>().GameDataObject;
        public static Item CutPassionFruit => (Item)GDOUtils.GetCustomGameDataObject<CutPassionFruit>().GameDataObject;
        public static Item EggFoamS0 => (Item)GDOUtils.GetCustomGameDataObject<EggFoamS0>().GameDataObject;
        public static Item EggFoamS1 => (Item)GDOUtils.GetCustomGameDataObject<EggFoamS1>().GameDataObject;
        public static Item EggWhite => (Item)GDOUtils.GetCustomGameDataObject<EggWhite>().GameDataObject;
        public static Item EggYolk => (Item)GDOUtils.GetCustomGameDataObject<EggYolk>().GameDataObject;
        public static Item FairyBreadCut => (Item)GDOUtils.GetCustomGameDataObject<FairyBreadCut>().GameDataObject;
        public static Item KiwiFruit => (Item)GDOUtils.GetCustomGameDataObject<KiwiFruit>().GameDataObject;
        public static Item MashedPassionFruit => (Item)GDOUtils.GetCustomGameDataObject<MashedPassionFruit>().GameDataObject;
        public static Item PassionFruit => (Item)GDOUtils.GetCustomGameDataObject<PassionFruit>().GameDataObject;
        public static Item SprinklesBag => (Item)GDOUtils.GetCustomGameDataObject<SprinklesBag>().GameDataObject;
        public static Item Vegemite => (Item)GDOUtils.GetCustomGameDataObject<Vegemite>().GameDataObject;
        public static Item VegemiteJar => (Item)GDOUtils.GetCustomGameDataObject<VegemiteJar>().GameDataObject;
        public static Item BurnedPavlovaTin => (Item)GDOUtils.GetCustomGameDataObject<BurnedPavlovaTin>().GameDataObject;
        public static Item CookedPavlovaBase => (Item)GDOUtils.GetCustomGameDataObject<CookedPavlovaBase>().GameDataObject;
        public static Item CookedPavlovaTin => (Item)GDOUtils.GetCustomGameDataObject<CookedPavlovaTin>().GameDataObject;

        #endregion

        #region ItemGroup

        public static ItemGroup ButteredBread => (ItemGroup)GDOUtils.GetCustomGameDataObject<ButteredBread>().GameDataObject;
        public static ItemGroup CutPavlovaBase => (ItemGroup)GDOUtils.GetCustomGameDataObject<CutPavlovaBase>().GameDataObject;
        public static ItemGroup FairyBread => (ItemGroup)GDOUtils.GetCustomGameDataObject<FairyBread>().GameDataObject;
        public static ItemGroup PavlovaSlice => (ItemGroup)GDOUtils.GetCustomGameDataObject<PavlovaSlice>().GameDataObject;
        public static ItemGroup PlatedFairyBread => (ItemGroup)GDOUtils.GetCustomGameDataObject<PlatedFairyBread>().GameDataObject;
        public static ItemGroup PlatedVegemiteToast => (ItemGroup)GDOUtils.GetCustomGameDataObject<PlatedVegemiteToast>().GameDataObject;
        public static ItemGroup RawPavlovaTin => (ItemGroup)GDOUtils.GetCustomGameDataObject<RawPavlovaTin>().GameDataObject;
        public static ItemGroup SugaredEggFoam => (ItemGroup)GDOUtils.GetCustomGameDataObject<SugaredEggFoam>().GameDataObject;
        public static ItemGroup VegemiteToast => (ItemGroup)GDOUtils.GetCustomGameDataObject<VegemiteToast>().GameDataObject;

        #endregion

        #region Dish

        public static Dish DishFairyBread => (Dish)GDOUtils.GetCustomGameDataObject<DishFairyBread>().GameDataObject;
        public static Dish DishPavlova => (Dish)GDOUtils.GetCustomGameDataObject<DishPavlova>().GameDataObject;
        public static Dish DishPavlovaToppings => (Dish)GDOUtils.GetCustomGameDataObject<DishPavlovaToppings>().GameDataObject;
        public static Dish DishVegemiteToast => (Dish)GDOUtils.GetCustomGameDataObject<DishVegemiteToast>().GameDataObject;
        public static Dish DishVegemiteToastCheese => (Dish)GDOUtils.GetCustomGameDataObject<DishVegemiteToastCheese>().GameDataObject;

        #endregion

        #region Appliance

        public static Appliance OutbackGround => (Appliance)GDOUtils.GetCustomGameDataObject<OutbackGround>().GameDataObject;
        public static Appliance OutbackTree => (Appliance)GDOUtils.GetCustomGameDataObject<OutbackTree>().GameDataObject;
        public static Appliance RoadWithCars => (Appliance)GDOUtils.GetCustomGameDataObject<RoadWithCars>().GameDataObject;
        public static Appliance RoughTerrainLeft => (Appliance)GDOUtils.GetCustomGameDataObject<RoughTerrainLeft>().GameDataObject;
        public static Appliance RoughTerrainRight => (Appliance)GDOUtils.GetCustomGameDataObject<RoughTerrainRight>().GameDataObject;
        public static Appliance SprinklesProvider => (Appliance)GDOUtils.GetCustomGameDataObject<SprinklesProvider>().GameDataObject;
        public static Appliance VegemiteProvider => (Appliance)GDOUtils.GetCustomGameDataObject<VegemiteProvider>().GameDataObject;
        public static Appliance PassionFruitProvider => (Appliance)GDOUtils.GetCustomGameDataObject<PassionFruitProvider>().GameDataObject;
        public static Appliance KiwiFruitProvider => (Appliance)GDOUtils.GetCustomGameDataObject<KiwiFruitProvider>().GameDataObject;

        #endregion
    }
}