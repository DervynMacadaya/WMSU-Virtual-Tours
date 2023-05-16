using UnityEngine;

public class DisplayTargetLoc : MonoBehaviour
{
    [SerializeField] private GameObject _targetIcon;

    private void Start() => HideTargetLocIcon();

    public void DisplayTargetLocIcon() =>_targetIcon.SetActive(true);

    public void HideTargetLocIcon() => _targetIcon.SetActive(false);

}
