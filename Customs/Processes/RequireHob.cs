using AussieClassics.Utilities;
using KitchenData;
using KitchenLib.Customs;

namespace AussieClassics.Customs.Processes
{
    public class RequireHob : CustomProcess
    {
        public override string UniqueNameID => "RequireHob";
        public override GameDataObject BasicEnablingAppliance => GDOReferences.Hob;
        public override Process IsPseudoprocessFor => GDOReferences.Cook;
    }
}