using TMPro;
using UnityEngine;

public class MoveLocIcon : MonoBehaviour
{
    [SerializeField] private Transform agent;
    [SerializeField] private Transform target;
    [SerializeField] private TMP_Text text;
    [SerializeField] private Transform icon;
    [SerializeField] private Vector3 offset;
    [SerializeField] private Camera cam;

    private void LateUpdate()
    {
        Vector3 screenPos = cam.WorldToScreenPoint(target.position + offset);

        if (transform.position != screenPos)
            transform.position = screenPos;

        //if (transform.position.z < 0)
        //{
        //    icon.gameObject.SetActive(false);
        //    text.gameObject.SetActive(false);
        //}
        //else
        //{
        //    icon.gameObject.SetActive(true);
        //    text.gameObject.SetActive(true);
        //}
    }

    private void Update()
    {
        float dist = Vector3.Distance(agent.position, target.position) / 2f;
        text.text = dist.ToString("0.0") + " m";
    }
}
