using System.Diagnostics.CodeAnalysis;
using HarmonyLib;
using UnityEngine;

namespace FeralBright.Patches;

[HarmonyPatch(typeof(TimeOfDay))]
public class TimeOfDayPatches
{
    private static readonly int SunAnimatorTimeOfDayHash = Animator.StringToHash("timeOfDay");

    [HarmonyPatch("MoveTimeOfDay")]
    [HarmonyPostfix]
    private static void PostFix_MoveTimeOfDay([SuppressMessage("ReSharper", "InconsistentNaming")] ref Animator ___sunAnimator)
    {
        if (Config.Sun.EnablePositionOverride && ___sunAnimator)
            ___sunAnimator.SetFloat(SunAnimatorTimeOfDayHash, Config.Sun.PositionOverride);
    }
}
