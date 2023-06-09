using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopGameOver : MonoBehaviour
{
    public Image BGpop;
    public Image imgPop;
    public Button botonReiniciar;
    public Text metrosRecorridos;
    public GameObject popGameOverGO;
    //public Image imagenFundido;
    public Cronometro cronometroScript;
    public GameObject musicaJuego;
    public AudioClip musicaGameOver;
    public GameObject Coche;

    void Start()
    {
        popGameOverGO.SetActive(false);
    }

    public void ActivoGameOver()
    {
        musicaJuego.GetComponent<AudioSource>().clip = musicaGameOver;
        musicaJuego.GetComponent<AudioSource>().Play();
        botonReiniciar.gameObject.SetActive(true);
        BGpop.CrossFadeAlpha(1, 0.3f, false);
        imgPop.CrossFadeAlpha(1, 0.3f, false);
        metrosRecorridos.CrossFadeAlpha(1, 0.3f, false);
        metrosRecorridos.text = ((int)cronometroScript.distancia).ToString() + "m";
        Coche.GetComponent<AudioSource>().Stop();
    }

    public void ReiniciarJuego()
    {
        //imagenFundido.CrossFadeAlpha(1, 0.5f, false);
        StartCoroutine(CargoEscena());
    }

    IEnumerator CargoEscena()
    {
        yield return new WaitForSeconds(1);
        Application.LoadLevel("Scene1");
    }
}
