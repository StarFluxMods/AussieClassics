using System.Collections.Generic;
using AussieClassics.Customs.Generic;
using AussieClassics.Utilies;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Appliances
{
    public class WaferProvider : GenericProvider
    {
        public override string UniqueNameID => "WaferProvider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("WaferProvider").AssignMaterialsByNames();
        public override Item ProvidedItem => GDOReferences.WaferSheet;
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.WaferProvider; 
    }
}