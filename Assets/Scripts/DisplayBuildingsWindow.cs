using UnityEngine;

public class DisplayBuildingsWindow : MonoBehaviour
{
    [SerializeField] private GameObject _buildingsWindow;
    [SerializeField] private GameObject _floatingButtons;
    [SerializeField] private GameObject _infoButtons;
    [SerializeField] private GameObject _icons;
    [SerializeField] private GameObject _targetLoc;

    public void DisplayBuildings()
    {
        _targetLoc.SetActive(false);
        _icons.SetActive(false);
        _floatingButtons.SetActive(false);
        _infoButtons.SetActive(false);

        _buildingsWindow.SetActive(true);
    }

    public void CloseBuildings()
    {
        _targetLoc.SetActive(true);
        _icons.SetActive(true);
        _floatingButtons.SetActive(true);
        _infoButtons.SetActive(true);

        _buildingsWindow.SetActive(false);
        
        
    }
}
