using FeralCommon.Input;
using UnityEngine.InputSystem;

namespace FeralBright;

public static class Toggles
{
    public static ButtonToggle Flashlight { get; } = ButtonToggle.Create(Key.F, "ToggleFlashlight", "Toggle \"hands-free\" flashlight");
    public static ButtonToggle SunInside { get; } = ButtonToggle.Create(Key.T, "ToggleSunInside", "Toggle sun visibility within facility");
}
