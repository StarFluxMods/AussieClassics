using System.Collections.Generic;
using AussieClassics.Customs.Generic;
using AussieClassics.Utilies;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Appliances
{
    public class PassionFruitProvider : GenericProvider
    {
        public override string UniqueNameID => "PassionFruitProvider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PassionFruitProvider").AssignMaterialsByNames();

        public override Item ProvidedItem => GDOReferences.PassionFruit;
        
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.PassionFruitProvider; 
    }
}