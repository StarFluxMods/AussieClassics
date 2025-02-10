using System.Collections.Generic;
using AussieClassics.Utilities;
using Kitchen;
using KitchenData;
using KitchenLib.Achievements;
using KitchenLib.Utils;
using KitchenMods;

namespace AussieClassics.Systems
{
    public class UnlockableCosmetics : GameSystemBase, IModSystem
    {

        public static PlayerCosmetic masterCosmetic => GDOReferences.GoldenKoala;

        public static UnlockableCosmetics instance;

        protected override void Initialise()
        {
            base.Initialise();
            instance = this;
            CheckMasterCosmetic();
        }

        protected override void OnUpdate()
        {
        }
        
        public void CheckMasterCosmetic()
        {
            masterCosmetic.DisableInGame = true;
            foreach (Achievement achievement in Mod.achievementsManager.GetAchievements())
            {
                if (!achievement.HasCompleted) return;
            }
            masterCosmetic.DisableInGame = false;
        }
    }
}