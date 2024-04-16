using System.Diagnostics.CodeAnalysis;
using FeralCommon.Utils;
using HarmonyLib;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

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

    [HarmonyPatch(nameof(TimeOfDay.SetInsideLightingDimness))]
    [HarmonyPostfix]
    private static void PostFix_SetInsideLightingDimness([SuppressMessage("ReSharper", "InconsistentNaming")] ref Light ___sunIndirect,
        [SuppressMessage("ReSharper", "InconsistentNaming")] ref HDAdditionalLightData ___indirectLightData)
    {
        if (!Player.LocalPlayer().isInsideFactory || !Toggles.SunInside) return;

        if (___sunIndirect)
        {
            ___sunIndirect.enabled = true;
            ___sunIndirect.intensity = Config.Sun.InsideIntensity;
        }

        if (___indirectLightData)
            ___indirectLightData.lightDimmer = 16;
    }
}
