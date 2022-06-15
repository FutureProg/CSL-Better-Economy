using ICities;
using ColossalFramework.UI;


namespace BetterEconomy
{

    public class AreaManager : AreasExtensionBase
    {

        // public int OnGetAreaPrice(uint ore, uint oil, uint forest, uint fertility, uint water, bool road, bool train, bool ship, bool plane, float landFlatness, int originalPrice)
        // {
        //     return 100_000;
        // }
        public override int OnGetAreaPrice(uint ore, uint oil, uint forest, uint fertility, uint water, bool road, bool train, bool ship, bool plane, float landFlatness, int originalPrice)
        {
            return 100000;
        }
    }

    public class BetterEconomyLoader : LoadingExtensionBase {
        public override void OnLevelLoaded(LoadMode mode)
        {
            // create dialog panel
            ExceptionPanel panel = UIView.library.ShowModal<ExceptionPanel>("ExceptionPanel");

            // display a message for the user in the panel
            panel.SetMessage("City Beautifier", "The level is loaded!", false);
        }
    } 
}