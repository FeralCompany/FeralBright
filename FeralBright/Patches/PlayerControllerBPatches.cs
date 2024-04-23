using FeralBright.Behaviors;
using FeralCommon.Utils;
using GameNetcodeStuff;
using HarmonyLib;

namespace FeralBright.Patches;

[HarmonyPatch(typeof(PlayerControllerB))]
public static class PlayerControllerBPatches
{
    [HarmonyPostfix]
    [HarmonyPatch(nameof(PlayerControllerB.ConnectClientToPlayerObject))]
    private static void PostFix_ConnectClientToPlayerObject(PlayerControllerB __instance)
    {
        __instance.gameObject.AddComponent<Flashlight>();
        __instance.gameplayCamera.cullingMask += Mask.Unused2;
    }
}
