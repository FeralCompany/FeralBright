using FeralCommon.Input;

namespace FeralBright;

public static class Toggles
{
    public static ButtonToggle Flashlight { get; } = new("ToggleFlashlight", "Toggle \"hands-free\" flashlight", "<keyboard>/f");
    public static ButtonToggle SunInside { get; } = new("ToggleSunInside", "Toggle sun visibility within facility", "<keyboard>/t");
}
