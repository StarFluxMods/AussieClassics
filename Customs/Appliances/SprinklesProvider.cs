using System.Collections.Generic;
using AussieClassics.Customs.Generic;
using AussieClassics.Utilies;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Appliances
{
    public class SprinklesProvider : GenericProvider
    {
        public override string UniqueNameID => "SprinklesProvider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("SprinklesProvider").AssignMaterialsByNames();

        public override Item ProvidedItem => GDOReferences.SprinklesBag;
        
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.SprinklesProvider; 
    }
}