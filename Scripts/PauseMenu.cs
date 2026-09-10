using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private Button BTNContinue;
    [SerializeField] private Button BTNSettings;
    [SerializeField] private Button BTNCredits;
    [SerializeField] private Button BTNExit;
    [SerializeField] public GameObject pauseMenu;
    [SerializeField] private GameObject mainMenuCanvas;
    [SerializeField] private GameObject creditsMenu;
    [SerializeField] private GameObject SettingsMenu;



    private void Awake()
    {
        BTNContinue.onClick.AddListener(ContinueClicked);
        BTNSettings.onClick.AddListener(SettingsClicked);
        BTNCredits.onClick.AddListener(CreditsClicked);
        BTNExit.onClick.AddListener(ExitClicked);
    }

    private void OnDestroy()
    {
        BTNContinue.onClick.RemoveAllListeners();
        BTNSettings.onClick.RemoveAllListeners();
        BTNCredits.onClick.RemoveAllListeners();
        BTNExit.onClick.RemoveAllListeners();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(!pauseMenu.activeSelf);
        }
    }

    private void ContinueClicked()
    {
        Debug.Log("Continue button clicked");
        mainMenuCanvas.SetActive(false);
        creditsMenu.SetActive(false);
        SettingsMenu.SetActive(false);
        pauseMenu.SetActive(false);

    }

    private void SettingsClicked()
    {
        Debug.Log("Settings button clicked");
        SettingsMenu.SetActive(true);
        mainMenuCanvas.SetActive(false);
        creditsMenu.SetActive(false);

    }
    private void CreditsClicked()
    {
        Debug.Log("Credits button clicked");
        creditsMenu.SetActive(true);
        mainMenuCanvas.SetActive(false);
        SettingsMenu.SetActive(false);

    }
    private void ExitClicked()
    {
        Debug.Log("Exit button clicked");
        mainMenuCanvas.SetActive(true);
        creditsMenu.SetActive(false);
        SettingsMenu.SetActive(false);
        pauseMenu.SetActive(false);
    }
}
