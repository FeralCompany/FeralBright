using FeralCommon.Utils;
using UnityEngine;

namespace FeralBright.Behaviors;

public class Flashlight : MonoBehaviour
{
    private static Light _light = null!;

    public void Awake()
    {
        if (_light) Destroy(_light);

        _light = new GameObject("FeralBright_Flashlight").AddComponent<Light>();
        _light.transform.SetParent(Player.LocalPlayer().playerEye.transform);
        _light.transform.rotation = Quaternion.LookRotation(Player.LocalPlayer().playerEye.transform.forward);

        _light.cullingMask = Mask.Unused2;
        _light.type = LightType.Spot;
    }

    public void Update()
    {
        _light.enabled = Toggles.Flashlight;
        _light.intensity = Config.Flashlight.Intensity;
        _light.range = Config.Flashlight.Range;
        _light.spotAngle = Config.Flashlight.Spread;
        _light.color = Config.Flashlight.Color;

        var relativePosition = new Vector3(Config.Flashlight.OffsetX, Config.Flashlight.OffsetY, Config.Flashlight.OffsetZ);
        var relativeRotation = Quaternion.Euler(Config.Flashlight.Yaw * -1, Config.Flashlight.Pitch, 0);
        _light.transform.SetLocalPositionAndRotation(relativePosition, relativeRotation);
    }
}
