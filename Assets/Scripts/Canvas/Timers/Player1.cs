using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1 : MonoBehaviour {

    [Tooltip("tiempo inicial en segundos")]
    public int tiempoInicial = 30;

    [Tooltip("escala de tiempo del reloj")]
    [Range(-10.0f, 10.0f)]
    public float escalaDeTiempo = -1;
    public bool reiniciarReloj;
    private Text myText;
    private float tiempoDelFrameConTimeScale = 0f;
    private float tiempoAMostrarEnSegundos = 0f;
    private float escalaDeTiempoAlPausar, escalaDeTiempoInicial;
    public bool Player1Lose = false;

    public GameObject Canvas;
    public GameObject Pausa;
    // Use this for initialization
    void Start ()
    {
        tiempoInicial = 30;
        escalaDeTiempoInicial = escalaDeTiempo;
        myText = GetComponent<Text>();
        tiempoAMostrarEnSegundos = tiempoInicial;
        ActualizarReloj(tiempoInicial);
    }
    // Update is called once per frame
    void Update()
    {
        if (Canvas.GetComponent<CambioDePlayer>().whosPlaying == 1 && Pausa.GetComponent<Pausa>().allStop == false)
        {
            tiempoDelFrameConTimeScale = Time.deltaTime * escalaDeTiempo;
            tiempoAMostrarEnSegundos += tiempoDelFrameConTimeScale;
            ActualizarReloj(tiempoAMostrarEnSegundos);
        }
        else if(Canvas.GetComponent<CambioDePlayer>().whosPlaying == 2 && Pausa.GetComponent<Pausa>().allStop == false)
        {
            tiempoAMostrarEnSegundos = 30;
            ActualizarReloj(30);
        }
    }
    public void ActualizarReloj(float tiempoEnSegundos)
    {
        int minutos = 0;
        int segundos = 0;
        string textoDelReloj;

        if (tiempoEnSegundos < 0)
        {
            Player1Lose = true;
            tiempoEnSegundos = 0;
        }
        else
        {
            Player1Lose = false;
        }
        minutos = (int)tiempoEnSegundos / 60;
        segundos = (int)tiempoEnSegundos % 60;

        textoDelReloj = minutos.ToString("00") + ":" + segundos.ToString("00");
        myText.text = textoDelReloj;
    }
}

