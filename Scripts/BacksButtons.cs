using UnityEngine;
using UnityEngine.UI;

public class BacksButtons : MonoBehaviour
{
    [SerializeField] private Button BacksButton;
    [SerializeField] private GameObject SettingMenu;
    [SerializeField] private GameObject MainMenu;
    [SerializeField] private GameObject Credits;
    [SerializeField] public GameObject PauseMenu;

    private void Awake()
    {
        BacksButton.onClick.AddListener(onBackButtonClicked);
    }

    private void onBackButtonClicked()
    {
        Debug.Log("Back button clicked");

        if (PauseMenu.activeSelf)
        {
            if (SettingMenu.activeSelf)
            {
                SettingMenu.SetActive(false);
                
            }
            else if (Credits.activeSelf)
            {
                Credits.SetActive(false);
                
            }

            Credits.SetActive(false);
            SettingMenu.SetActive(false);
        }
        else if (MainMenu.activeSelf)
        {
            if (SettingMenu.activeSelf)
            {
                SettingMenu.SetActive(false);
                
            }
            else if (Credits.activeSelf)
            {
                Credits.SetActive(false);
                
            }
            Credits.SetActive(false);
            SettingMenu.SetActive(false);
        }

    }
}
