using BepInEx;
using FeralBright.Patches;
using FeralCommon.Plugin;
using HarmonyLib;

namespace FeralBright;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
internal class FeralBrightPlugin : FeralPlugin
{
    private readonly Harmony _harmony = new(MyPluginInfo.PLUGIN_GUID);

    protected override void Load()
    {
        RegisterConfigs(typeof(Config));
        RegisterButtons(typeof(Toggles));

        _harmony.PatchAll(typeof(PlayerControllerBPatches));
        _harmony.PatchAll(typeof(TimeOfDayPatches));
    }

    protected override void Enable() { }
}
