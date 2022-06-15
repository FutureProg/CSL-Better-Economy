using ICities;

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
            ModSettings.OnSettingsUI(helper);
    }

}
}