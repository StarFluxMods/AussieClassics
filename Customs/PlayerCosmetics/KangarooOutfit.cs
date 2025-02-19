﻿using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.PlayerCosmetics
{
    public class KangarooOutfit : CustomPlayerCosmetic
    {
        public override string UniqueNameID => "KangarooOutfit";
        public override CosmeticType CosmeticType => CosmeticType.Hat;
        public override GameObject Visual => Mod.Bundle.LoadAsset<GameObject>("KangarooHead").AssignMaterialsByNames();
        public override float HeadSize => 0.4f;
        public override bool BlockHats => true;

        public override void OnRegister(PlayerCosmetic gameDataObject)
        {
            PlayerOutfitComponent playerOutfitComponent = gameDataObject.Visual.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(gameDataObject.Visual, "Head").GetComponent<SkinnedMeshRenderer>());
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(gameDataObject.Visual, "Tail").GetComponent<SkinnedMeshRenderer>());
            
        }
    }
}