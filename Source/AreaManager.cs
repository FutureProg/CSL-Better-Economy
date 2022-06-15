using ICities;
using ColossalFramework.UI;


namespace BetterEconomy
{

    public class AreaManager : AreasExtensionBase
    {      
        public override int OnGetAreaPrice(uint ore, uint oil, uint forest, uint fertility, uint water, bool road, bool train, bool ship, bool plane, float landFlatness, int originalPrice)
        {
            int baseCost = 1000;
            int finalCost = baseCost;
            // industry weighting
            finalCost += (int)(water * (ModSettings.waterRatio*baseCost));

            return finalCost * 100; // multiply by 100 because if it returns 100 the game outputs $1.00
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