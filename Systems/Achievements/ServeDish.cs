using AussieClassics.Components;
using Kitchen;
using KitchenLib.References;
using KitchenMods;
using Unity.Collections;
using Unity.Entities;

namespace AussieClassics.Systems.Achievements
{
    public class ServeDish : RestaurantSystem, IModSystem
    {
        private EntityQuery _WaitingForItems;
        
        protected override void Initialise()
        {
            base.Initialise();
            _WaitingForItems = GetEntityQuery(new QueryHelper().All(typeof(CWaitingForItem)).None(typeof(CCompletedAchievementEntity)));
        }

        protected override void OnUpdate()
        {
            using (NativeArray<Entity> WaitingForItems = _WaitingForItems.ToEntityArray(Allocator.Temp))
            {
                foreach (Entity WaitingForItem in WaitingForItems)
                {
                    if (!RequireBuffer(WaitingForItem, out DynamicBuffer<CWaitingForItem> buffer)) continue;
                    foreach (var cWaitingForItem in buffer)
                    {
                        if (Require(cWaitingForItem.Item, out CItem cItem) && cWaitingForItem.ItemID == ItemGroupReferences.PizzaPlated && cWaitingForItem.Satisfied)
                        {
                            bool foundEgg = false;
                            foreach (int item in cItem.Items)
                            {
                                if (item == ItemReferences.EggCooked)
                                {
                                    EntityManager.AddComponent<CCompletedAchievementEntity>(WaitingForItem);
                                    Mod.achievementsManager.UnlockAchievement(Mod.ACHIEVEMENT_EGG_PIZZA);
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}