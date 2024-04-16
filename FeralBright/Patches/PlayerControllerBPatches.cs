using System.Diagnostics.CodeAnalysis;
using FeralBright.Behaviors;
using FeralCommon.Utils;
using GameNetcodeStuff;
using HarmonyLib;
using UnityEngine;

namespace FeralBright.Patches;

[HarmonyPatch(typeof(PlayerControllerB))]
public static class PlayerControllerBPatches
{
    [HarmonyPatch("Awake")]
    [HarmonyPostfix]
    private static void PostFix_Awake([SuppressMessage("ReSharper", "InconsistentNaming")] PlayerControllerB __instance)
    {
        __instance.StartCoroutine(Player.WhenLocalPlayerReady(player =>
        {
            if (player != __instance)
                return;

            var newGameObject = new GameObject();

            var newTransform = newGameObject.transform;
            newTransform.SetParent(player.playerEye.transform);
            newTransform.rotation = Quaternion.LookRotation(player.playerEye.transform.forward);
            newGameObject.AddComponent<FeralFlashlight>();
        }));
    }
}
