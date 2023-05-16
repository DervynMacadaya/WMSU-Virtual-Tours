using UnityEngine;

public class DisplayTravelBTN : MonoBehaviour
{
    [SerializeField] private GameObject _travelBTN;

    private void Start()
    {
        HideTravel_BTN();
    }

    public void DisplayTravel_BTN()
    {
        _travelBTN.SetActive(true);
    }

    public void HideTravel_BTN()
    {
        _travelBTN.SetActive(false);
    }
}
