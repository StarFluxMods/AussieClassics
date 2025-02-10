using System.Collections.Generic;
using AussieClassics.Customs.Generic;
using AussieClassics.Utilies;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Appliances
{
    public class ShoeProvider : GenericProvider
    {
        public override string UniqueNameID => "ShoeProvider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("ShoeProvider").AssignMaterialsByNames();

        public override Item ProvidedItem => GDOReferences.Shoe;

        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.ShoeProvider;
    }
}