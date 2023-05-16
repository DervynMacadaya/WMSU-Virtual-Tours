using UnityEngine;

public class RotateCompass : MonoBehaviour
{
    [SerializeField] private Transform targetRot;
    [SerializeField] private float Z_axis_Offset;

    private void LateUpdate()
    {
        var eulerAngles = targetRot.eulerAngles;
        transform.rotation = Quaternion.Euler(0, 0, eulerAngles.y + Z_axis_Offset);
    }
}
