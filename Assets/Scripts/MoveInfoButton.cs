using UnityEngine;

public class MoveInfoButton : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Transform button;
    [SerializeField] private Vector3 offset;
    [SerializeField] private Camera cam;

    private void LateUpdate()
    {
        Vector3 screenPos = cam.WorldToScreenPoint(target.position + offset);

        if (button.position != screenPos)
            button.position = screenPos;
        if (button.position.z < 0)
            button.gameObject.SetActive(false);
        else
            button.gameObject.SetActive(true);


    }
}
