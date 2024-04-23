using BepInEx;
using FeralCommon;
using FeralCommon.Utils;
using FeralCommon.Utils.Extensions;
using LethalCompanyInputUtils.Api;

namespace FeralBright;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
[BepInDependency(FeralCommon.MyPluginInfo.PLUGIN_GUID)]
[BepInDependency(Compat.LethalConfigKey)]
[BepInDependency(Compat.InputUtilsKey)]
internal class FeralBrightPlugin : FeralPlugin
{
    protected override void Load()
    {
        RegisterConfigs(typeof(Config));
        RegisterButtons(typeof(Toggles));

        var binder = new BinderWorkAround(this);
        CompleteWorkAroundPartTwo(binder);

        Harmony.PatchNamespace("FeralBright.Patches");
    }

    private class BinderWorkAround(FeralPlugin plugin) : LcInputActions
    {
        public override void CreateInputActions(in InputActionMapBuilder builder)
        {
            plugin.CompleteWorkAroundPartOne(in builder);
        }
    }
}
