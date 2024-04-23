using FeralBright.Behaviors;
using HarmonyLib;
using UnityEngine;

namespace FeralBright.Patches;

[HarmonyPatch(typeof(StartOfRound))]
public static class StartOfRoundPatch
{
    private static GameObject _facilitySun = null!;

    [HarmonyPostfix]
    [HarmonyPatch("Awake")]
    private static void Postfix_Awake()
    {
        if (_facilitySun) Object.Destroy(_facilitySun);

        _facilitySun = new GameObject("FeralBright_FacilitySun");
        _facilitySun.AddComponent<FacilitySun>();
    }
}
