using BepInEx;

namespace MyFirstPlugin
{
    [BepInPlugin("reeleese.bepinex.plugins.myfirstplugin", "My First Plugin", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }
    }
}


// A class that inherits BaseUnityPlugin
// A BepinPlugin Attribute that contains the plugin's GUID, name, and version
// Plugin startup code