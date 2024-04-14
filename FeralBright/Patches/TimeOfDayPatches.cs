using FeralCommon.Utils;
using HarmonyLib;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace FeralBright.Patches;

[HarmonyPatch(typeof(TimeOfDay))]
public class TimeOfDayPatches
{
    private static readonly int SunAnimatorTimeOfDayHash = Animator.StringToHash("timeOfDay");

    [HarmonyPatch(nameof(TimeOfDay.MoveTimeOfDay))]
    [HarmonyPostfix]
    private static void PostFix_MoveTimeOfDay(ref Animator ___sunAnimator)
    {
        if (Config.Sun.EnablePositionOverride && ___sunAnimator)
            ___sunAnimator.SetFloat(SunAnimatorTimeOfDayHash, Config.Sun.PositionOverride);
    }

    [HarmonyPatch(nameof(TimeOfDay.SetInsideLightingDimness))]
    [HarmonyPostfix]
    private static void PostFix_SetInsideLightingDimness(ref Light ___sunIndirect, ref HDAdditionalLightData ___indirectLightData)
    {
        if (!PlayerUtil.LocalPlayer().isInsideFactory || !Toggles.SunInside)
            return;

        if (___sunIndirect)
        {
            ___sunIndirect.enabled = true;
            ___sunIndirect.intensity = Config.Sun.InsideIntensity;
        }

        if (___indirectLightData)
            ___indirectLightData.lightDimmer = 16;
    }
}
