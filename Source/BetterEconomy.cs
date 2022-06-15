using ICities;
using UnityEngine;
using ColossalFramework;
using ColossalFramework.Globalization;
using ColossalFramework.IO;
using ColossalFramework.UI;
using System;

namespace BetterEconomy {

public class BetterEconomy: IUserMod
{
    public string Name {
        get { return "Better Economy"; }
    }

    public string Description {
        get { return "Improvements to in-game economy!"; }
    }

    public void OnSettingsUI(UIHelperBase helper) {
        try {
            
            UIHelperBase grp = helper.AddGroup(Name);
            UIPanel panel = ((UIHelper)grp).self as UIPanel;            
            grp.AddSlider("Ore",0,1,0.01f,0.0f, (b)=>{ModSettings.oreRatio = b;});
            grp.AddSlider("Water",0,1,0.01f,0.0f, (b)=>{ModSettings.waterRatio = b;});

        } catch(Exception e) {
            Logger.Debug("OnSettingsUI Failed");
            Logger.LogException(e);                        
        }
    }

}
}