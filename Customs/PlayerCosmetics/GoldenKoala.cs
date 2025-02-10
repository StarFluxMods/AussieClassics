using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.PlayerCosmetics
{
    public class GoldenKoala : CustomPlayerCosmetic
    {
        public override string UniqueNameID => "GoldenKoala";
        public override CosmeticType CosmeticType => CosmeticType.Hat;
        public override GameObject Visual => Mod.Bundle.LoadAsset<GameObject>("GoldenKoalaHat").AssignMaterialsByNames().AssignVFXByNames();
        public override float HeadSize => 0.85f;
        public override bool BlockHats => true;

        public override void OnRegister(PlayerCosmetic gameDataObject)
        {
            PlayerOutfitComponent playerOutfitComponent = gameDataObject.Visual.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(gameDataObject.Visual, "KoalaHead").GetComponent<SkinnedMeshRenderer>());
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(gameDataObject.Visual, "GoldenGlow").GetComponent<SkinnedMeshRenderer>());
            
            playerOutfitComponent.Hats.Add(GameObjectUtils.GetChildObject(gameDataObject.Visual, "KoalaHead").GetComponent<SkinnedMeshRenderer>());
            playerOutfitComponent.Hats.Add(GameObjectUtils.GetChildObject(gameDataObject.Visual, "GoldenGlow").GetComponent<SkinnedMeshRenderer>());
            
        }
    }
}