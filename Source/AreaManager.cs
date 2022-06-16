using ICities;
using ColossalFramework.UI;


namespace BetterEconomy
{

    public class AreaManager : AreasExtensionBase
    {      
        public override int OnGetAreaPrice(uint ore, uint oil, uint forest, uint fertility, uint water, bool road, bool train, bool ship, bool plane, float landFlatness, int originalPrice)
        {
            Logger.Info(string.Format("Received the following values for area:\nore{0},oil:{1},forest:{2},fertility:{3},water:{4},landFlatness:{5},originalPrice:{6}", ore, oil, forest, fertility, water, landFlatness, originalPrice));
            int baseCost = 400000;
            float finalCost = baseCost;
            // industry weighting
            // ore
            finalCost += ore * (ModSettings.resourceWeighting * 3);
            finalCost += oil * (ModSettings.resourceWeighting * 4);
            finalCost += fertility * (ModSettings.resourceWeighting * 2);
            finalCost += forest * (ModSettings.resourceWeighting * 1);

            // Connections and Water
            if (water > ModSettings.minimumWaterAmount)
            {
                finalCost += ModSettings.resourceWeighting * (water/255);                                
            }
            if (ship)
            {
                finalCost += ModSettings.connectionWeighting * finalCost;
            }
            if (train)
            {
                finalCost += ModSettings.connectionWeighting * finalCost;
            }
            if (road)
            {
                finalCost += ModSettings.connectionWeighting * finalCost;
            }
            if (plane)
            {
                finalCost += ModSettings.connectionWeighting * finalCost;
            }

            // Buildability
            finalCost += finalCost * landFlatness * ModSettings.flatnessWeighting;
            Logger.Info(string.Format("New Cost: {0}", (int)(finalCost * 100)));
            return (int)(finalCost * 100); // multiply by 100 because if it returns 100 the game outputs $1.00
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