using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class SettingPl2 : MonoBehaviour
{

    [SerializeField] private Moving2 Jugador2;

    [SerializeField] private Slider player2Speed;

    [SerializeField] private Slider player2Height;

    [SerializeField] private TMP_Text Player2Speed;

    [SerializeField] private TMP_Text Player2Height;

    [SerializeField] private Transform TransformPlayer2;

    private Vector3 originalscale;


    private void Awake()
    {
        player2Speed.onValueChanged.AddListener(OnPlayer2SpeedChanged);
        player2Height.onValueChanged.AddListener(OnPlayer2HeightChanged);
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

}
