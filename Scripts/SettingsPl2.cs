using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Proyect04
{

    public class SettingPl2 : MonoBehaviour
{

    [SerializeField] private Moving2 Jugador2;

    [SerializeField] private Slider player2Speed;

    [SerializeField] private Slider player2Height;

    [SerializeField] private Button ButtonRed2;

    [SerializeField] private Button ButtonBlue2;

    [SerializeField] private Button ButtonGreen2;

    [SerializeField] private TMP_Text Player2Speed;

    [SerializeField] private TMP_Text Player2Height;

    [SerializeField] private Transform TransformPlayer2;

    [SerializeField] private Renderer player2Render;

    private Vector3 originalscale;


    private void Awake()
    {
        player2Speed.onValueChanged.AddListener(OnPlayer2SpeedChanged);
        player2Height.onValueChanged.AddListener(OnPlayer2HeightChanged);
        ButtonRed2.onClick.AddListener(OnRedButtonClicked);
        ButtonBlue2.onClick.AddListener(OnBlueButtonClicked);
        ButtonGreen2.onClick.AddListener(OnGreenButtonClicked);
    }

    private void Start()
    {
        originalscale = TransformPlayer2.localScale;
    }

    private void OnPlayer2SpeedChanged(float value)
    {
        Jugador2.Velocity2 = value;
        Player2Speed.text = value.ToString("F2");
    }

    private void OnPlayer2HeightChanged(float value)
    {
        float height = value * 2;

        TransformPlayer2.localScale = new Vector3(originalscale.x, originalscale.y * height, originalscale.z);

        Player2Height.text = value.ToString("F2");
    }

    private void OnRedButtonClicked()
    {
        player2Render.material.color = Color.red;
    }

    private void OnBlueButtonClicked()
    {
        player2Render.material.color = Color.blue;
    }

    private void OnGreenButtonClicked()
    {
        player2Render.material.color = Color.green;
    }

}

}

