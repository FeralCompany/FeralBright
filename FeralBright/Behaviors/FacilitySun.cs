using FeralCommon.Utils;
using UnityEngine;

namespace FeralBright.Behaviors;

public class FacilitySun : MonoBehaviour
{
    private Light _sun = null!;

    private void Awake()
    {
        _sun = gameObject.AddComponent<Light>();
        _sun.type = LightType.Directional;
        _sun.shape = LightShape.Cone;
        _sun.color = Color.white;
        _sun.transform.position = new Vector3(0F, 1000F, 0F);
        _sun.transform.rotation = Quaternion.Euler(90F, 0F, 0F);
        _sun.cullingMask = Mask.Unused2;
    }

    private void Update()
    {
        var player = Player.LocalPlayerNullable();
        if (!player || !player!.isInsideFactory)
        {
            _sun.enabled = false;
            return;
        }

        _sun.enabled = Toggles.SunInside;
        _sun.intensity = Config.Sun.InsideIntensity;
    }
}
