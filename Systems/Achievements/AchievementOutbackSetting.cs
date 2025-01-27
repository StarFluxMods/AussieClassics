using System;
using AussieClassics.Components;
using AussieClassics.Utilities;
using HarmonyLib;
using Kitchen;
using KitchenMods;
using Unity.Collections;
using Unity.Entities;

namespace AussieClassics.Systems.Achievements
{
    public class AchievementOutbackSetting : RestaurantSystem, IModSystem
    {
        private EntityQuery _Settings;
        protected override void Initialise()
        {
            base.Initialise();
            _Settings = GetEntityQuery(new QueryHelper().All(typeof(CSetting)).None(typeof(CCompletedAchievementEntity)));
        }

        protected override void OnUpdate()
        {
            if (HasSingleton<ProvideStartingEnvelopes.SProvided>())
            {
                return;
            }
            if (!Has<SLayout>())
            {
                return;
            }
            
            using (NativeArray<Entity> Settings = _Settings.ToEntityArray(Allocator.Temp))
            {
                foreach (Entity Setting in Settings)
                {
                    if (!Require(Setting, out CSetting cSetting)) continue;
                    if (cSetting.RestaurantSetting == GDOReferences.Outback.ID)
                    {
                        EntityManager.AddComponent<CCompletedAchievementEntity>(Setting);
                        Mod.achievementsManager.UnlockAchievement(Mod.ACHIEVEMENT_OUTBACK_SETTING);
                        return;
                    }
                }
            }
        }
    }
}