using UnityEngine;
using UnityEngine.UI;

public class MoveButton : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Transform button;
    [SerializeField] private Vector3 offset;
    [SerializeField] private Camera cam;
    [SerializeField] private float maxFadeDistance;
    [SerializeField] private Image img;
    [SerializeField] private Button btn;

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

    private void Update()
    {
        if (Vector3.Distance(target.position, cam.transform.position) > maxFadeDistance)
        {
            img.enabled = false;
            btn.enabled = false;
        }
        else
        {
            img.enabled = true;
            btn.enabled = true;
        }
    }
}
