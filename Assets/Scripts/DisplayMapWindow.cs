using UnityEngine;

public class DisplayMapWindow : MonoBehaviour
{
    [SerializeField] private GameObject MapWindow;

    public void DisplayMap()
    {
        MapWindow.SetActive(true);
    }

    public void CloseMap()
    {
        MapWindow.SetActive(false);
    }
}
