using System.Collections.Generic;
using KitchenLib;
using KitchenLib.Logging.Exceptions;
using KitchenMods;
using System.Linq;
using System.Reflection;
using AussieClassics.Utilities;
using Kitchen;
using KitchenData;
using KitchenLib.Achievements;
using KitchenLib.Event;
using KitchenLib.Interfaces;
using KitchenLib.References;
using KitchenLib.Utils;
using TMPro;
using UnityEngine;
using KitchenLogger = KitchenLib.Logging.KitchenLogger;

namespace AussieClassics
{
    // https://www.flaticon.com/free-icon/whisk_184490 - Wisk Icon
    // https://sketchfab.com/3d-models/low-poly-kangaroo-31950174017f4fdc8ec7ade267da7c2f - Kangaroo
    
    // TODO : Snake in Sink Animation
    // TODO : Kangaroo Model & Animation
    
    // TODO : Tim Tams
    // TODO : Lamington
    // TODO : Fish & Chips
    // TODO : VB
    
    // TODO : Cosmetics
    // TODO : Achievements
    // TODO : Decor
    
    public class Mod : BaseMod, IModSystem, IAutoRegisterAll
    {
        public const string MOD_GUID = "com.starfluxgames.aussieclassics";
        public const string MOD_NAME = "Aussie Classics";
        public const string MOD_VERSION = "0.1.0";
        public const string MOD_AUTHOR = "StarFluxGames";
        public const string MOD_GAMEVERSION = ">=1.2.0";

        public static bool ENABLE_ADDITIONAL_LOBBY_DISHES = false;
        
        internal static readonly string ACHIEVEMENT_BURN_PAVLOVA = "ACHIEVEMENT_BURN_PAVLOVA";
        internal static readonly string ACHIEVEMENT_TIM_TAM_COFFEE = "ACHIEVEMENT_TIM_TAM_COFFEE";

        internal static AssetBundle Bundle;
        internal static KitchenLogger Logger;

        internal static AchievementsManager achievementsManager;
        
        public Mod() : base(MOD_GUID, MOD_NAME, MOD_AUTHOR, MOD_VERSION, MOD_GAMEVERSION, Assembly.GetExecutingAssembly()) { }

        protected override void OnInitialise()
        {
            Logger.LogWarning($"{MOD_GUID} v{MOD_VERSION} in use!");
            // RefGenerator.LocalisationDumper(Path.Combine(Application.persistentDataPath, "Localisation Dumps"));
        }

        protected override void OnUpdate()
        {
        }

        protected override void OnPostActivate(KitchenMods.Mod mod)
        {
            Bundle = mod.GetPacks<AssetBundleModPack>().SelectMany(e => e.AssetBundles).FirstOrDefault() ?? throw new MissingAssetBundleException(MOD_GUID);
            Logger = InitLogger();
            
            /*
            achievementsManager = new AchievementsManager(MOD_GUID, MOD_NAME);
            achievementsManager.RegisterAchievement(new Achievement(ACHIEVEMENT_BURN_PAVLOVA, "How'd you manage that?", "Burn a Pavlova", null));
            achievementsManager.RegisterAchievement(new Achievement(ACHIEVEMENT_TIM_TAM_COFFEE, "Old Classic", "Serve a Tim Tam and a Coffee to the same Customer", null));
            achievementsManager.Load();
            achievementsManager.Save();
            */
            
            Bundle.LoadAllAssets<Texture2D>();
            Bundle.LoadAllAssets<Sprite>();
            var spriteAsset = Bundle.LoadAsset<TMP_SpriteAsset>("WhiskIcon");
            TMP_Settings.defaultSpriteAsset.fallbackSpriteAssets.Add(spriteAsset);
            spriteAsset.material = GameObject.Instantiate(TMP_Settings.defaultSpriteAsset.material);
            spriteAsset.material.mainTexture = Bundle.LoadAsset<Texture2D>("WhiskIcon_Tex");

            Events.BuildGameDataEvent += (sender, args) =>
            {
                if (!args.firstBuild) return;
                if (args.gamedata.TryGet(ApplianceReferences.Countertop, out Appliance counter) && args.gamedata.TryGet(GDOReferences.VegemiteProvider.ID, out Appliance vegemiteProvider))
                {
                    foreach (Appliance.ApplianceProcesses process in counter.Processes)
                    {
                        bool found = false;
                        foreach (Appliance.ApplianceProcesses process2 in vegemiteProvider.Processes)
                        {
                            if (process2.Process == process.Process)
                            {
                                found = true;
                            }
                        }
                        if (!found)
                        {
                            vegemiteProvider.Processes.Add(process);
                        }
                    }
                }

                if (args.gamedata.TryGet(ItemReferences.EggCracked, out Item EggCracked) &&
                    args.gamedata.TryGet(GDOReferences.EggWhite.ID, out Item EggWhite) &&
                    args.gamedata.TryGet(GDOReferences.EggYolk.ID, out Item EggYolk))
                {
                    EggCracked.SplitCount = 1;
                    EggCracked.SplitSubItem = EggYolk;
                    EggCracked.SplitDepletedItems = new List<Item> { EggWhite };
                }
                
                if (args.gamedata.TryGet(ApplianceReferences.Mixer, out Appliance Mixer))
                {
                    AddProcessToAppliance(Mixer, new Appliance.ApplianceProcesses
                    {
                        Process = GDOReferences.Whisk,
                        Speed = 1,
                        Validity = ProcessValidity.Generic,
                        IsAutomatic = true
                    });
                }

                if (args.gamedata.TryGet(ApplianceReferences.Hob, out Appliance Hob))
                {
                    AddProcessToAppliance(Hob, new Appliance.ApplianceProcesses
                    {
                        Process = GDOReferences.RequireHob,
                        Speed = 1,
                        Validity = ProcessValidity.Generic,
                        IsAutomatic = false
                    });
                }
                
                CustomPizzaIngredient.AddPizzaIngredientToPrefabs(args.gamedata,
                    Bundle.LoadAsset<GameObject>("EggRaw").AssignMaterialsByNames(),
                    GDOReferences.EggCracked,
                    Bundle.LoadAsset<GameObject>("EggCooked").AssignMaterialsByNames(),
                    GDOReferences.EggCooked,
                    "E");
            };

            // RefGenerator.GenerateGDOReferences(Assembly.GetExecutingAssembly(), Path.Combine(Application.persistentDataPath, "GeneratedReferences.cs"));
        }

        private void AddProcessToAppliance(Appliance appliance, Appliance.ApplianceProcesses process)
        {
            bool found = false;
            foreach (Appliance.ApplianceProcesses x in appliance.Processes)
            {
                if (x.Process == process.Process)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                appliance.Processes.Add(process);
            }
        }

        private static FieldInfo _Sets = ReflectionUtils.GetField<ItemGroup>("Sets");
        private static FieldInfo _Processes = ReflectionUtils.GetField<Item>("Processes");
        private static FieldInfo _ComponentLabels = ReflectionUtils.GetField<ItemGroupView>("ComponentLabels");
        
        private void AddProcessToItem(Item item, Item.ItemProcess process)
        {
            List<Item.ItemProcess> Processes = (List<Item.ItemProcess>)_Processes.GetValue(item);
            bool found = false;
            foreach (Item.ItemProcess x in Processes)
            {
                if (x.Process == process.Process)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Processes.Add(process);
                _Processes.SetValue(item, Processes);
            }
        }
    }
}