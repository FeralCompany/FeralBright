using UnityEngine;

namespace FeralBright.Behaviors;

public class FeralFlashlight : MonoBehaviour
{
    private Light? _light;

    public void Awake()
    {
        _light = gameObject.AddComponent<Light>();
        _light.type = LightType.Spot;
        _light.enabled = Toggles.Flashlight;
    }

    public void Update()
    {
        if (!_light) return;

        _light!.enabled = Toggles.Flashlight;
        _light.intensity = Config.Flashlight.Intensity;
        _light.range = Config.Flashlight.Range;
        _light.spotAngle = Config.Flashlight.Spread;
        _light.color = Config.Flashlight.Color;

        var relativePosition = new Vector3(Config.Flashlight.OffsetX, Config.Flashlight.OffsetY, Config.Flashlight.OffsetZ);
        var relativeRotation = Quaternion.Euler(Config.Flashlight.Yaw * -1, Config.Flashlight.Pitch, 0);
        _light.transform.SetLocalPositionAndRotation(relativePosition, relativeRotation);
    }
}
