using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;

namespace AussieClassics.Customs.Generic
{
    public abstract class SceneAppliance : CustomAppliance
    {
        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            new CImmovable(),
            new CStatic()
        };

        public override bool IsNonInteractive => true;
    }
}