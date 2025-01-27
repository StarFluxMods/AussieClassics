using AussieClassics.Components;
using AussieClassics.Utilities;
using Kitchen;
using KitchenLib.References;
using KitchenMods;
using Unity.Collections;
using Unity.Entities;

namespace AussieClassics.Systems.Achievements
{
    public class AchievementTimTamSmash : RestaurantSystem, IModSystem
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
                    if (!RequireBuffer(WaitingForItem, out DynamicBuffer<CWaitingForItem> cWaitingForItemBuffer)) continue;
                    if (!RequireBuffer(WaitingForItem, out DynamicBuffer<CGroupMember> cGroupMemberBuffer)) continue;
                    foreach (var cWaitingForItem in cWaitingForItemBuffer)
                    {
                        if ((cWaitingForItem.ItemID == ItemGroupReferences.Latte ||
                             cWaitingForItem.ItemID == ItemGroupReferences.IcedCoffee ||
                             cWaitingForItem.ItemID == ItemGroupReferences.CoffeeCupCoffee) 
                            && cWaitingForItem.Satisfied)
                        {
                            if (cGroupMemberBuffer.Length >= cWaitingForItem.MemberIndex)
                            {
                                CGroupMember member = cGroupMemberBuffer[cWaitingForItem.MemberIndex];
                                if (member.Customer != Entity.Null)
                                {
                                    if (Has<CHasHadTimTam>(member.Customer))
                                    {
                                        Set<CCompletedAchievementEntity>(WaitingForItem);
                                        Mod.achievementsManager.UnlockAchievement(Mod.ACHIEVEMENT_TIMTAM_SMASH);
                                        return;
                                    }
                                }
                            }
                        }

                        if (cWaitingForItem.ItemID == GDOReferences.TimTam.ID && cWaitingForItem.Satisfied)
                        {
                            if (cGroupMemberBuffer.Length >= cWaitingForItem.MemberIndex)
                            {
                                CGroupMember member = cGroupMemberBuffer[cWaitingForItem.MemberIndex];
                                if (member.Customer != Entity.Null)
                                {
                                    Set<CHasHadTimTam>(member.Customer);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}