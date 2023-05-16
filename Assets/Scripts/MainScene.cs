using UnityEngine;
using UnityEngine.UI;

public class MainScene : MonoBehaviour
{
    [SerializeField] private GameObject _pauseBG;
    [SerializeField] private GameObject _floatingButtonsBG;
    [SerializeField] private GameObject _infoButtonsBG;
    [SerializeField] private GameObject _confirmExitBG;
    [SerializeField] private GameObject _menuBG;
    [SerializeField] private GameObject _mainBG;
    [SerializeField] private GameObject _icons;
    [SerializeField] private GameObject _targetLoc;

    public void PauseScene()
    {
        _targetLoc.SetActive(false);
        _icons.SetActive(false);
        _floatingButtonsBG.SetActive(false);
        _infoButtonsBG.SetActive(false);

        _pauseBG.SetActive(true);
    }

    public void ResumeScene()
    {
        _targetLoc.SetActive(true);
        _icons.SetActive(true);
        _infoButtonsBG.SetActive(true);
        _floatingButtonsBG.SetActive(true);

        _pauseBG.SetActive(false);
    }

    public void ExitScene()
    {
        _confirmExitBG.SetActive(true);
        //_pauseBG.SetActive(false);
    }

    public void CancelExitConfirmation()
    {
        _pauseBG.SetActive(true);
        _confirmExitBG.SetActive(false);
    }

    public void ConfirmExit()
    {
        _menuBG.SetActive(true);
        _mainBG.SetActive(false);
    }
}
