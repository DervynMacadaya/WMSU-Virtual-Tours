using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum Desc
{
    Canteen = 0,
    OpenField = 1,
    OpenStage = 2,
    VolleyballCourt = 3,
    BasketballCourt = 4,
    HealthService = 5,
    Education = 6
}

public enum Title
{
    Canteen = 0,
    OpenField = 1,
    OpenStage = 2,
    VolleyballCourt = 3,
    BasketballCourt = 4,
    HealthService = 5,
    Education = 6
}

public class DisplayInfo : MonoBehaviour
{
    [Header("backgrounds")]
    [SerializeField] private GameObject _infoDisplay;
    [SerializeField] private GameObject _editDesc;
    [SerializeField] private GameObject _floatingButtons;
    [SerializeField] private GameObject _infoButtons;
    [SerializeField] private GameObject _icons;
    [SerializeField] private GameObject _targetLoc;

    [Header("Texts")]
    [SerializeField] private TMP_InputField _title;
    [SerializeField] private TMP_InputField _desc_edit;
    [SerializeField] private TMP_Text _desc;


    private Title currentTitle;
    private Desc currentDesc;

    public void CloseDesc()
    {
        PlayerPrefs.SetString(currentTitle.ToString() + "_Title", _title.text);
        _icons.SetActive(true);
        _targetLoc.SetActive(true);
        _infoButtons.SetActive(true);
        _floatingButtons.SetActive(true);

        _infoDisplay.SetActive(false);
    }

    public void CloseEditDesc()
    {
        _infoDisplay.SetActive(true);
        _editDesc.SetActive(false);
    }

    public void DisplayDesc(int descIndex)
    {
        _icons.SetActive(false);
        _targetLoc.SetActive(false);
        _infoButtons.SetActive(false);
        _floatingButtons.SetActive(false);

        _infoDisplay.SetActive(true);

        currentTitle = (Title)descIndex;
        currentDesc = (Desc)descIndex;
        _title.text = PlayerPrefs.GetString(currentTitle.ToString() + "_Title");
        _desc.text = PlayerPrefs.GetString(currentDesc.ToString());
    }

    public void DisplayEditDesc()
    {
        _editDesc.SetActive(true);
        _infoDisplay.SetActive(false);

        _desc_edit.text = PlayerPrefs.GetString(currentDesc.ToString());
    }

    public void SetDesc()
    {
        PlayerPrefs.SetString(currentDesc.ToString(), _desc_edit.text);
                
        _infoDisplay.SetActive(true);
        _editDesc.SetActive(false);

        _desc.text = PlayerPrefs.GetString(currentDesc.ToString());
    }
}
