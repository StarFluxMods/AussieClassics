using AussieClassics.Customs.Generic;
using AussieClassics.Views.Local;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Appliances
{
    public class RoughTerrainLeft : SceneAppliance
    {
        public override string UniqueNameID => "RoughTerrainLeft";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RoughTerrainLeft").AssignMaterialsByNames();
        
        public override void OnRegister(Appliance gameDataObject)
        {
            base.OnRegister(gameDataObject);
            
            GameObject Car = gameDataObject.Prefab.GetChild("Cars/CarContainer1/Car");
            CarView view = Car.AddComponent<CarView>();
            view.Car = Car;
            view.animator = Car.GetComponentInChildren<Animator>();
            
            
            GameObject Car2 = gameDataObject.Prefab.GetChild("Cars/CarContainer2/Car");
            CarView view2 = Car2.AddComponent<CarView>();
            view2.Car = Car2;
            view2.animator = Car2.GetComponentInChildren<Animator>();
        }
    }
}