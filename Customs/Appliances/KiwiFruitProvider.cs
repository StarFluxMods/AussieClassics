using System.Collections.Generic;
using AussieClassics.Customs.Generic;
using AussieClassics.Utilies;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Appliances
{
    public class KiwiFruitProvider : GenericProvider
    {
        public override string UniqueNameID => "KiwiFruitProvider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("KiwiFruitProvider").AssignMaterialsByNames();
        public override Item ProvidedItem => GDOReferences.KiwiFruit;
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.KiwiFruitProvider; 
    }
}