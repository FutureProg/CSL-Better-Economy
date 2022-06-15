using ICities;
using UnityEngine;
using ColossalFramework;
using ColossalFramework.Globalization;
using ColossalFramework.IO;
using ColossalFramework.UI;
using System;

namespace BetterEconomy {
    public class ModSettings {

        public static float resourceWeighting = 0.25f;
        public static float connectionWeighting = 0.3f;
        public static int minimumWaterAmount = 12000;
        public static float flatnessWeighting = 0.0f;

        public static void OnSettingsUI(UIHelperBase helper)
        {
            try
            {

                UIHelperBase grp = helper.AddGroup("Better Economy");
                UIPanel panel = ((UIHelper)grp).self as UIPanel;
                grp.AddSlider("Resource Weighting", 0, 1, 0.01f, resourceWeighting, (b) => { ModSettings.resourceWeighting = b; Logger.Debug("resourceWeighting: " + b); });
                grp.AddSlider("Connection Weighting", 0, 1, 0.01f, connectionWeighting, (b) => { ModSettings.connectionWeighting = b; Logger.Debug("connectionWeighting: " + b); });
                grp.AddSlider("Land Flatness Weighting", 0, 1, 0.01f, flatnessWeighting, (b) => { ModSettings.flatnessWeighting = b; Logger.Debug("flatnessWeighting: " + b); });
                grp.AddSlider("Minimum Water Amount", 12000, 300000, 100, minimumWaterAmount, (b) => { ModSettings.minimumWaterAmount = (int)b; Logger.Debug("minimumWaterAmount: " + b); });

            }
            catch (Exception e)
            {
                Logger.Debug("OnSettingsUI Failed");
                Logger.LogException(e);
            }
        }
        

    }
}