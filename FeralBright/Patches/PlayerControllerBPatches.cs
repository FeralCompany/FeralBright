using FeralBright.Behaviors;
using FeralCommon.Utils;
using GameNetcodeStuff;
using HarmonyLib;
using UnityEngine;

namespace FeralBright.Patches;

[HarmonyPatch(typeof(PlayerControllerB))]
public class PlayerControllerBPatches
{
    [HarmonyPatch(nameof(PlayerControllerB.Awake))]
    [HarmonyPostfix]
    private static void PostFix_Awake(ref PlayerControllerB __instance, ref Transform ___playerEye)
    {
        if (!PlayerUtil.IsLocalPlayer(__instance)) return;

        var gameObject = new GameObject();

        var transform = gameObject.transform;
        transform.SetParent(___playerEye.transform);
        transform.rotation = Quaternion.LookRotation(___playerEye.transform.forward);

        gameObject.AddComponent<FeralFlashlight>();
    }
}
