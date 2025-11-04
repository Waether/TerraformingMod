using System.Xml.Serialization;
using Assets.Scripts;
using Assets.Scripts.Objects;

namespace TerraformingMod
{
    [XmlInclude(typeof(ThingSaveData))]
    [XmlRoot("TerraformingAtmosphere")]
    public class TerraformingAtmosphere
    {
        [XmlElement]
        public GlobalGasMixSaveData GasMix = null;
    }
}
