using System.Collections.Generic;
using AussieClassics.Utilies;
using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Customs;

namespace AussieClassics.Customs.Processes
{
    public class Whisk : CustomProcess
    {
        public override string UniqueNameID => "Whisk";
        public override GameDataObject BasicEnablingAppliance => GDOReferences.Mixer;
        public override bool CanObfuscateProgress => true;
        public override List<(Locale, ProcessInfo)> InfoList => CenteralLang.Processes.Whisk;
    }
}