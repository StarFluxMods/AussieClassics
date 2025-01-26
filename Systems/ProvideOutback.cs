using AussieClassics.Utilities;
using Kitchen;
using KitchenMods;
using Unity.Collections;
using Unity.Entities;

namespace AussieClassics.Systems
{
    public class ProvideOutback : GameSystemBase, IModSystem
    {

        private EntityQuery _settingUpgrades;
        
        protected override void Initialise()
        {
            base.Initialise();
            _settingUpgrades = GetEntityQuery(typeof(CSettingUpgrade));
        }

        protected override void OnUpdate()
        {
            using NativeArray<Entity> settingUpgrades = _settingUpgrades.ToEntityArray(Allocator.TempJob);
            foreach (Entity settingUpgrade in settingUpgrades)
            {
                if (Require(settingUpgrade, out CSettingUpgrade cSettingUpgrade))
                {
                    if (cSettingUpgrade.SettingID == GDOReferences.Outback.ID)
                    {
                        return;
                    }
                }
            }
            
            Entity e = EntityManager.CreateEntity(typeof(CSettingUpgrade));
            EntityManager.SetComponentData(e, new CSettingUpgrade
            {
                SettingID = GDOReferences.Outback.ID
            });
        }
    }
}