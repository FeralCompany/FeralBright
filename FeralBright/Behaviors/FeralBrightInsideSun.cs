using FeralCommon.Utils;
using UnityEngine;

namespace FeralBright.Behaviors;

public class FeralBrightInsideSun : MonoBehaviour
{
    private Light _insideSun = null!;

    private void Awake()
    {
        _insideSun = gameObject.AddComponent<Light>();
        _insideSun.type = LightType.Directional;
        _insideSun.shape = LightShape.Cone;
        _insideSun.color = Color.white;
        _insideSun.transform.localPosition = new Vector3(0F, 100F, 0F);
        _insideSun.transform.rotation = Quaternion.Euler(90F, 0F, 0F);
        _insideSun.bounceIntensity = 0F;
    }

    private void Update()
    {
        var player = Player.LocalPlayerNullable();
        if (!player || !player!.isInsideFactory)
        {
            _insideSun.enabled = false;
            return;
        }

        _insideSun.enabled = Toggles.SunInside;
        _insideSun.intensity = Config.Sun.InsideIntensity;
    }
}
