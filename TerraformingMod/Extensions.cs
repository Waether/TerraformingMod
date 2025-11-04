using Assets.Scripts;
using Assets.Scripts.Atmospherics;

namespace TerraformingMod
{
    public static class Extensions
    {
        #region GlobalGasMixData

        public static GasMixture GetGasMixture(this GlobalGasMixData value)
        {
            // TODO

            return new GasMixture();
        }

        public static GlobalGasMixSaveData GetGlobalGasMixSaveDataFromGasMixture(GasMixture value)
        {
            // TODO

            return new GlobalGasMixSaveData();
        }

        #endregion GlobalGasMixData

        #region Atmosphere

        public static bool IsCloseToGlobal(this Atmosphere atmo, float minPressure)
        {
            return atmo.IsCloseToGlobal(minPressure);
        }

        #endregion Atmosphere
    }
}
