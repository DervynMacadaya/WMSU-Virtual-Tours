using UnityEngine;
using UnityEngine.UI;

public class AdjustSunAngle : MonoBehaviour
{
    [SerializeField] private Transform sun;
    [SerializeField] private Slider x;
    [SerializeField] private Slider y;

    [SerializeField] private GameObject _floatingButtons;
    [SerializeField] private GameObject _infoButtons;
    [SerializeField] private GameObject _sunAngleWindow;
    [SerializeField] private GameObject _icons;
    [SerializeField] private GameObject _targetLoc;

    [SerializeField] private Button resetBTN;

    private void Update()
    {
        sun.rotation = Quaternion.Euler(x.value, y.value, 0);
    }

    public void DisplaySunAngle()
    {
        _targetLoc.SetActive(false);
        _icons.SetActive(false);
        _floatingButtons.SetActive(false);
        _infoButtons.SetActive(false);

        _sunAngleWindow.SetActive(true);
    }

    public void CloseSunAngle()
    {
        _targetLoc.SetActive(true);
        _icons.SetActive(true);
        _floatingButtons.SetActive(true);
        _infoButtons.SetActive(true);

        _sunAngleWindow.SetActive(false);
    }
    public void ResetToDefault()
    {
        x.value = 120.89f;
        y.value = 277.9f;
    }
}
