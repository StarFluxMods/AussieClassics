using System.Collections.Generic;
using AussieClassics.Customs.Generic;
using AussieClassics.Utilies;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace AussieClassics.Customs.Appliances
{
    public class VBProvider : GenericProvider
    {
        public override string UniqueNameID => "VBProvider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("VBProvider").AssignMaterialsByNames();

        public override Item ProvidedItem => GDOReferences.VBCan;

        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.VBProvider;
    }
}