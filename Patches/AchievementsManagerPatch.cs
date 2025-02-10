using System.Reflection;
using AussieClassics.Systems;
using HarmonyLib;
using KitchenLib.Achievements;
using KitchenLib.Utils;

namespace AussieClassics.Patches
{
    [HarmonyPatch(typeof(AchievementsManager), "CompleteAchievement")]
    public class AchievementsManagerPatch
    {
        private static FieldInfo modId = ReflectionUtils.GetField<AchievementsManager>("modId");

        static void Postfix(AchievementsManager __instance, bool __result, string key)
        {
            if (!__result) return;
            if (UnlockableCosmetics.instance == null) return;
            if ((string)modId.GetValue(__instance) != Mod.MOD_GUID) return;

            UnlockableCosmetics.instance.CheckMasterCosmetic();
        }
    }
}