using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuPrincipal : MonoBehaviour
{
    [SerializeField] private Moving1 Jugador1;
    [SerializeField] private Moving2 Jugador2;
    [SerializeField] private Button btnPlay;
    [SerializeField] private Button btnCredits;
    [SerializeField] private Button btnSettings;


    [SerializeField] private GameObject StartMenu;
    [SerializeField] private GameObject Credits;
    [SerializeField] private GameObject SettingMenu;
    [SerializeField] private GameObject PauseMenu;
    [SerializeField] private Slider player1Speed;
    [SerializeField] private Slider player2Speed;

    [SerializeField] private TMP_Text Player1Speed;
    [SerializeField] private TMP_Text Player2Speed;


    private void Awake()
    {
        btnPlay.onClick.AddListener(OnPlayButtonClicked);
        btnCredits.onClick.AddListener(OnCreditButtonClicked);
        btnSettings.onClick.AddListener(OnSettingsButtonClicked);
        player1Speed.onValueChanged.AddListener(OnPlayer1SpeedChanged);
        player2Speed.onValueChanged.AddListener(OnPlayer2SpeedChanged);
    }

    private void Start()
    {
       PauseMenu.SetActive(false);
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

    }

    private void OnPlayer1SpeedChanged(float value)
    {
        Jugador1.Velocity1 = value;
        Player1Speed.text = value.ToString("F2");
    }

    private void OnPlayer2SpeedChanged(float value)
    {
        Jugador2.Velocity2 = value;
        Player2Speed.text = value.ToString("F2");
    }
}
