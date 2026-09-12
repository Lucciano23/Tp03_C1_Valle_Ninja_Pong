using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class VelocityPl1 : MonoBehaviour
{

    [SerializeField] private Moving1 Jugador1;

    [SerializeField] private Slider player1Speed;

    [SerializeField] private Slider player1Height;

    [SerializeField] private Button ButtonRed1;

    [SerializeField] private Button ButtonBlue1;

    [SerializeField] private Button ButtonGreen1;

    [SerializeField] private TMP_Text Player1Speed;

    [SerializeField] private TMP_Text Player1Height;

    [SerializeField] private Transform TransformPlayer1;

    [SerializeField] private Renderer player1Render;

    

    private Vector3 originalscale;


    private void Awake()
    {
        player1Speed.onValueChanged.AddListener(OnPlayer1SpeedChanged);
        player1Height.onValueChanged.AddListener(OnPlayer1HeightChanged);
        ButtonRed1.onClick.AddListener(OnRedButtonClicked);
        ButtonBlue1.onClick.AddListener(OnBlueButtonClicked);
        ButtonGreen1.onClick.AddListener(OnGreenButtonClicked);
    }

    private void Start()
    {
        originalscale = TransformPlayer1.localScale;
    }


    private void OnPlayer1SpeedChanged(float value)
    {
        Jugador1.Velocity1 = value;
        Player1Speed.text = value.ToString("F2");
    }

    private void OnPlayer1HeightChanged (float value)
    {
        float height = value * 2;

        TransformPlayer1.localScale = new Vector3(originalscale.x, originalscale.y * height, originalscale.z);

        Player1Height.text = value.ToString("F2");
    }

    private void OnRedButtonClicked()
    {
       
        player1Render.material.color = Color.red;
    }

    private void OnBlueButtonClicked() 
    {
        player1Render.material.color = Color.blue;
    }

    private void OnGreenButtonClicked()
    {
        player1Render.material.color = Color.green;
    }

}
