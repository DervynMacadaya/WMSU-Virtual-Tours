using UnityEngine;

public class FollowCam : MonoBehaviour
{
    [SerializeField] private Transform cam;

    private void Update()
    {
        transform.position = new(cam.position.x, transform.position.y, cam.position.z);
    }
}
