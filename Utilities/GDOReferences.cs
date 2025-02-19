﻿using AussieClassics.Customs.Appliances;
using AussieClassics.Customs.Dishes;
using AussieClassics.Customs.ItemGroups;
using AussieClassics.Customs.Items;
using AussieClassics.Customs.PlayerCosmetics;
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
        public static Item EggCracked => (Item)GDOUtils.GetExistingGDO(ItemReferences.EggCracked);
        public static Item EggCooked => (Item)GDOUtils.GetExistingGDO(ItemReferences.EggCooked);
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
        public static Item ChocolateMelted => (Item)GDOUtils.GetExistingGDO(ItemReferences.ChocolateMelted);
        public static Item Chocolate => (Item)GDOUtils.GetExistingGDO(ItemReferences.Chocolate);

        #endregion

        #region ItemGroup

        public static ItemGroup PizzaPlated => (ItemGroup)GDOUtils.GetExistingGDO(ItemGroupReferences.PizzaPlated);

        #endregion

        #region Appliance

        public static Appliance Hob => (Appliance)GDOUtils.GetExistingGDO(ApplianceReferences.Hob);
        public static Appliance Countertop => (Appliance)GDOUtils.GetExistingGDO(ApplianceReferences.Countertop);
        public static Appliance Mixer => (Appliance)GDOUtils.GetExistingGDO(ApplianceReferences.Mixer);
        public static Appliance WallpaperApplicator => (Appliance)GDOUtils.GetExistingGDO(ApplianceReferences.WallpaperApplicator);
        public static Appliance FlooringApplicator => (Appliance)GDOUtils.GetExistingGDO(ApplianceReferences.FlooringApplicator);

        #endregion

        #region Dish

        public static Dish PizzaBase => (Dish)GDOUtils.GetExistingGDO(DishReferences.PizzaBase);

        #endregion

        #endregion

        #region RestaurantSetting

        public static RestaurantSetting Outback => (RestaurantSetting)GDOUtils.GetCustomGameDataObject<Outback>().GameDataObject;

        #endregion

        #region Process

        public static Process RequireHob => (Process)GDOUtils.GetCustomGameDataObject<RequireHob>().GameDataObject;
        public static Process Whisk => (Process)GDOUtils.GetCustomGameDataObject<Whisk>().GameDataObject;

        #endregion

        #region PlayerCosmetic

        public static PlayerCosmetic GoldenKoala => (PlayerCosmetic)GDOUtils.GetCustomGameDataObject<GoldenKoala>().GameDataObject;
        public static PlayerCosmetic KangarooOutfit => (PlayerCosmetic)GDOUtils.GetCustomGameDataObject<KangarooOutfit>().GameDataObject;

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
        public static Item OpenVBCan => (Item)GDOUtils.GetCustomGameDataObject<OpenVBCan>().GameDataObject;
        public static Item PassionFruit => (Item)GDOUtils.GetCustomGameDataObject<PassionFruit>().GameDataObject;
        public static Item Shoe => (Item)GDOUtils.GetCustomGameDataObject<Shoe>().GameDataObject;
        public static Item SprinklesBag => (Item)GDOUtils.GetCustomGameDataObject<SprinklesBag>().GameDataObject;
        public static Item VBCan => (Item)GDOUtils.GetCustomGameDataObject<VBCan>().GameDataObject;
        public static Item Vegemite => (Item)GDOUtils.GetCustomGameDataObject<Vegemite>().GameDataObject;
        public static Item VegemiteJar => (Item)GDOUtils.GetCustomGameDataObject<VegemiteJar>().GameDataObject;
        public static Item BurnedPavlovaTin => (Item)GDOUtils.GetCustomGameDataObject<BurnedPavlovaTin>().GameDataObject;
        public static Item CookedPavlovaBase => (Item)GDOUtils.GetCustomGameDataObject<CookedPavlovaBase>().GameDataObject;
        public static Item CookedPavlovaTin => (Item)GDOUtils.GetCustomGameDataObject<CookedPavlovaTin>().GameDataObject;
        public static Item CutWaferSheet => (Item)GDOUtils.GetCustomGameDataObject<CutWaferSheet>().GameDataObject;
        public static Item TimTam => (Item)GDOUtils.GetCustomGameDataObject<TimTam>().GameDataObject;
        public static Item WaferSheet => (Item)GDOUtils.GetCustomGameDataObject<WaferSheet>().GameDataObject;

        #endregion

        #region ItemGroup

        public static ItemGroup ButteredBread => (ItemGroup)GDOUtils.GetCustomGameDataObject<ButteredBread>().GameDataObject;
        public static ItemGroup CutPavlovaBase => (ItemGroup)GDOUtils.GetCustomGameDataObject<CutPavlovaBase>().GameDataObject;
        public static ItemGroup FairyBread => (ItemGroup)GDOUtils.GetCustomGameDataObject<FairyBread>().GameDataObject;
        public static ItemGroup PavlovaSlice => (ItemGroup)GDOUtils.GetCustomGameDataObject<PavlovaSlice>().GameDataObject;
        public static ItemGroup PlatedFairyBread => (ItemGroup)GDOUtils.GetCustomGameDataObject<PlatedFairyBread>().GameDataObject;
        public static ItemGroup PlatedVegemiteToast => (ItemGroup)GDOUtils.GetCustomGameDataObject<PlatedVegemiteToast>().GameDataObject;
        public static ItemGroup RawPavlovaTin => (ItemGroup)GDOUtils.GetCustomGameDataObject<RawPavlovaTin>().GameDataObject;
        public static ItemGroup Shoey => (ItemGroup)GDOUtils.GetCustomGameDataObject<Shoey>().GameDataObject;
        public static ItemGroup SugaredEggFoam => (ItemGroup)GDOUtils.GetCustomGameDataObject<SugaredEggFoam>().GameDataObject;
        public static ItemGroup TimTams => (ItemGroup)GDOUtils.GetCustomGameDataObject<TimTams>().GameDataObject;
        public static ItemGroup VegemiteToast => (ItemGroup)GDOUtils.GetCustomGameDataObject<VegemiteToast>().GameDataObject;

        #endregion

        #region Dish

        public static Dish DishFairyBread => (Dish)GDOUtils.GetCustomGameDataObject<DishFairyBread>().GameDataObject;
        public static Dish DishMeringue => (Dish)GDOUtils.GetCustomGameDataObject<DishMeringue>().GameDataObject;
        public static Dish DishPavlova => (Dish)GDOUtils.GetCustomGameDataObject<DishPavlova>().GameDataObject;
        public static Dish DishPavlovaToppings => (Dish)GDOUtils.GetCustomGameDataObject<DishPavlovaToppings>().GameDataObject;
        public static Dish DishPizzaEgg => (Dish)GDOUtils.GetCustomGameDataObject<DishPizzaEgg>().GameDataObject;
        public static Dish DishVegemiteToast => (Dish)GDOUtils.GetCustomGameDataObject<DishVegemiteToast>().GameDataObject;
        public static Dish DishVegemiteToastCheese => (Dish)GDOUtils.GetCustomGameDataObject<DishVegemiteToastCheese>().GameDataObject;
        public static Dish SideShoey => (Dish)GDOUtils.GetCustomGameDataObject<SideShoey>().GameDataObject;
        public static Dish SideTimTam => (Dish)GDOUtils.GetCustomGameDataObject<SideTimTam>().GameDataObject;

        #endregion

        #region Appliance

        public static Appliance BoomerangBoard => (Appliance)GDOUtils.GetCustomGameDataObject<BoomerangBoard>().GameDataObject;
        public static Appliance CrocodileSign => (Appliance)GDOUtils.GetCustomGameDataObject<CrocodileSign>().GameDataObject;
        public static Appliance KangarooSign => (Appliance)GDOUtils.GetCustomGameDataObject<KangarooSign>().GameDataObject;
        public static Appliance KiwiFruitProvider => (Appliance)GDOUtils.GetCustomGameDataObject<KiwiFruitProvider>().GameDataObject;
        public static Appliance KoalaBranch => (Appliance)GDOUtils.GetCustomGameDataObject<KoalaBranch>().GameDataObject;
        public static Appliance OutbackGround => (Appliance)GDOUtils.GetCustomGameDataObject<OutbackGround>().GameDataObject;
        public static Appliance OutbackTree => (Appliance)GDOUtils.GetCustomGameDataObject<OutbackTree>().GameDataObject;
        public static Appliance PassionFruitProvider => (Appliance)GDOUtils.GetCustomGameDataObject<PassionFruitProvider>().GameDataObject;
        public static Appliance RoadWithCars => (Appliance)GDOUtils.GetCustomGameDataObject<RoadWithCars>().GameDataObject;
        public static Appliance RoughTerrainLeft => (Appliance)GDOUtils.GetCustomGameDataObject<RoughTerrainLeft>().GameDataObject;
        public static Appliance RoughTerrainRight => (Appliance)GDOUtils.GetCustomGameDataObject<RoughTerrainRight>().GameDataObject;
        public static Appliance ShoeProvider => (Appliance)GDOUtils.GetCustomGameDataObject<ShoeProvider>().GameDataObject;
        public static Appliance SprinklesProvider => (Appliance)GDOUtils.GetCustomGameDataObject<SprinklesProvider>().GameDataObject;
        public static Appliance SurfBoardRack => (Appliance)GDOUtils.GetCustomGameDataObject<SurfBoardRack>().GameDataObject;
        public static Appliance VBProvider => (Appliance)GDOUtils.GetCustomGameDataObject<VBProvider>().GameDataObject;
        public static Appliance VegemiteProvider => (Appliance)GDOUtils.GetCustomGameDataObject<VegemiteProvider>().GameDataObject;
        public static Appliance WaferProvider => (Appliance)GDOUtils.GetCustomGameDataObject<WaferProvider>().GameDataObject;

        #endregion
    }
}