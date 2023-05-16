using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button _StartBTN;
    [SerializeField] private Button _SettingsBTN;
    [SerializeField] private Button _ExitBTN;

    [SerializeField] private Button _Start_BackBTN;
    [SerializeField] private Button _Settings_BackBTN;
    [SerializeField] private Button _YesBTN;
    [SerializeField] private Button _NoBTN;

    [Header("Backgrounds")]
    [SerializeField] private GameObject _MainBG;
    [SerializeField] private GameObject _MenuBG;
    [SerializeField] private GameObject _TitleBG;
    [SerializeField] private GameObject _StartBG;
    [SerializeField] private GameObject _SettingsBG;
    [SerializeField] private GameObject _ExitBG;
    [SerializeField] private GameObject _FloatingIconsBG;
    [SerializeField] private GameObject _IconsBG;
    [SerializeField] private GameObject _TargetLocBG;
    [SerializeField] private GameObject _InfoBG;
    [SerializeField] private GameObject _MainConfirmExitBG;
    [SerializeField] private GameObject _MainPauseBG;

    [Header("Start Page UI")]
    [SerializeField] private TMP_Dropdown _ControlsDD;
    [SerializeField] private TMP_Dropdown _StartLocDD;
    [SerializeField] private GameObject _GuidedTXT;
    [SerializeField] private GameObject _WalkTXT;
    [SerializeField] private GameObject _FirstPage;
    [SerializeField] private GameObject _SecondPage;

    [Header("UI Animations")]
    [SerializeField] private Animator _Controls_anim;
    [SerializeField] private Animator _Starting_anim;

    private void Start()
    {
        ShowTitlePage();
    }

    public void ShowMainScene()
    {
        _MainBG.SetActive(true);
        _FloatingIconsBG.SetActive(true);
        _IconsBG.SetActive(true);
        _TargetLocBG.SetActive(true);
        _InfoBG.SetActive(true);
        _MainConfirmExitBG.SetActive(false);
        _MainPauseBG.SetActive(false);
        _MenuBG.SetActive(false);
    }

    public void ShowTitlePage()
    {
        _TitleBG.SetActive(true);
        _StartBG.SetActive(false);
        _SettingsBG.SetActive(false);
        _ExitBG.SetActive(false);
    }

    public void ShowStartPage()
    {
        _TitleBG.SetActive(false);
        _StartBG.SetActive(true);
        _SecondPage.SetActive(false);
    }

    public void ShowSettingsPage()
    {
        _TitleBG.SetActive(false);
        _SettingsBG.SetActive(true);
    }

    public void ShowExitConfirm()
    {
        _TitleBG.SetActive(false);
        _ExitBG.SetActive(true);
    }

    public void ShowControlsDesc()
    {
        int _index = _ControlsDD.value;
        switch (_index)
        {
            case 0:
                _GuidedTXT.SetActive(true);
                _WalkTXT.SetActive(false);
                break;
            case 1:
                _GuidedTXT.SetActive(false);
                _WalkTXT.SetActive(true);
                break;
        }
    }

    public void ShowFirstPage()
    {
        _FirstPage.SetActive(true);
        _Controls_anim.SetBool("isIn", true);
        _Starting_anim.SetBool("isIn", false);
        //_SecondPage.SetActive(false);
    }

    public void ShowSecondPage()
    {
        //_FirstPage.SetActive(false);
        _SecondPage.SetActive(true);
        _Controls_anim.SetBool("isIn", false);
        _Starting_anim.SetBool("isIn", true);
    }

    public void ExitApp()
    {
        Application.Quit();
    }
}
