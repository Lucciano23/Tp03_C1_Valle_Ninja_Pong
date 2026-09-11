using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class VelocityPl1 : MonoBehaviour
{

    [SerializeField] private Moving1 Jugador1;

    [SerializeField] private Slider player1Speed;

    [SerializeField] private Slider player1Height;

    [SerializeField] private TMP_Text Player1Speed;

    [SerializeField] private TMP_Text Player1Height;

    [SerializeField] private Transform TransformPlayer1;

    private Vector3 originalscale;


    private void Awake()
    {
        player1Speed.onValueChanged.AddListener(OnPlayer1SpeedChanged);
        player1Height.onValueChanged.AddListener(OnPlayer1HeightChanged);

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


}
