using FeralBright.Behaviors;
using FeralCommon.Utils;
using GameNetcodeStuff;
using HarmonyLib;
using UnityEngine;

namespace FeralBright.Patches;

[HarmonyPatch(typeof(PlayerControllerB))]
public static class PlayerControllerBPatches
{
    [HarmonyPostfix]
    [HarmonyPatch(nameof(PlayerControllerB.ConnectClientToPlayerObject))]
    private static void PostFix_ConnectClientToPlayerObject(PlayerControllerB __instance)
    {
        CreateInsideSun(__instance);
        CreateFlashlight(__instance);
    }

    private static void CreateFlashlight(PlayerControllerB player)
    {
        var newGameObject = UnityTool.CreateRootGameObject("FeralBright_Flashlight");
        newGameObject.transform.SetParent(player.playerEye.transform);
        newGameObject.transform.rotation = Quaternion.LookRotation(player.playerEye.transform.forward);
        newGameObject.AddComponent<FeralFlashlight>();
    }

    private static void CreateInsideSun(PlayerControllerB player)
    {
        var newGameObject = UnityTool.CreateRootGameObject("FeralBright_InsideSun");
        newGameObject.transform.SetParent(player.playerEye.transform);
        newGameObject.AddComponent<FeralBrightInsideSun>();
    }
}
