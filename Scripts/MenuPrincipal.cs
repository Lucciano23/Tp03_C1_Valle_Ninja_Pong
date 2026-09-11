using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuPrincipal : MonoBehaviour
{
    
    
    [SerializeField] private Button btnPlay;

    [SerializeField] private Button btnCredits;

    [SerializeField] private Button btnSettings;

    [SerializeField] private GameObject StartMenu;

    [SerializeField] private GameObject Credits;

    [SerializeField] private GameObject SettingMenu;

    [SerializeField] private GameObject PauseMenu;

    private void Awake()
    {
        btnPlay.onClick.AddListener(OnPlayButtonClicked);
        btnCredits.onClick.AddListener(OnCreditButtonClicked);
        btnSettings.onClick.AddListener(OnSettingsButtonClicked);
       
        
    }

    private void Start()
    {
       PauseMenu.SetActive(false);
        Time.timeScale = 0;
    }

    private void OnDestroy()
    {
        btnPlay.onClick.RemoveAllListeners();
        btnCredits.onClick.RemoveAllListeners();
        btnSettings.onClick.RemoveAllListeners();
    }

    private void OnSettingsButtonClicked()
    {
        Debug.Log("Settings button clicked");
        SettingMenu.SetActive(true);
        
        Credits.SetActive(false);
    }

    private void OnCreditButtonClicked()
    {
        Debug.Log("Credit button clicked");
        Credits.SetActive(true);
        
        SettingMenu.SetActive(false);

    }



    private void OnPlayButtonClicked()
    {

        Debug.Log("Play button clicked!");
        StartMenu.SetActive(false);
        Credits.SetActive(false);
        SettingMenu.SetActive(false);
        PauseMenu.SetActive(false);
        Time.timeScale = 1;

    }

}
