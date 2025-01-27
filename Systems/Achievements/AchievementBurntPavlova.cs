using AussieClassics.Components;
using AussieClassics.Utilities;
using Kitchen;
using KitchenMods;
using Unity.Collections;
using Unity.Entities;

namespace AussieClassics.Systems.Achievements
{
    public class AchievementBurntPavlova : RestaurantSystem, IModSystem
    {
        private EntityQuery _Items;

        protected override void Initialise()
        {
            base.Initialise();
            _Items = GetEntityQuery(new QueryHelper().All(typeof(CItem)).None(typeof(CCompletedAchievementEntity)));
        }

        protected override void OnUpdate()
        {
            using (NativeArray<Entity> Items = _Items.ToEntityArray(Allocator.Temp))
            {
                foreach (Entity Item in Items)
                {
                    if (!Require(Item, out CItem cItem)) continue;
                    if (cItem.ID == GDOReferences.BurnedPavlovaTin.ID)
                    {
                        EntityManager.AddComponent<CCompletedAchievementEntity>(Item);
                        Mod.achievementsManager.UnlockAchievement(Mod.ACHIEVEMENT_BURN_PAVLOVA);
                        return;
                    }
                }
            }
        }
    }
}