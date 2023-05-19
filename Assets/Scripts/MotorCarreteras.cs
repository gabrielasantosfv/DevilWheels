using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorCarreteras : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject motorCarreteras;
    public GameObject[] contenedorCalles;

    public float speed;

    public int numSelectorDeCalle;
    public int contadorCalles = 0;

    public bool cuentaRegresivaTermino;
    public bool juegoTerminado;

    void Start()
    {
        juegoTerminado = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (cuentaRegresivaTermino && juegoTerminado == false)
        {
            motorCarreteras.transform.Translate(Vector3.down * speed * Time.deltaTime);

        }
    }

    public void CreaCalles()
    {
        numSelectorDeCalle = Random.Range(0, 5);
        GameObject Calle = (GameObject).Instantiante(contadorCalles, [numSelectorDeCalle], new Vector3(0, 50, 0), transform.rotation);
    }

    public void SpeedStop()
    {
        speed = 0;
    }

    public void SpeedArcen() 
    {
        speed = 5;
    }

    public void SpeedCarretera()
    {
        speed = 15;
    }

    public void SpeedCocheMalo()
    {
        speed = 3;
    }

    public void FinalizarJuego()
    {
        SpeedStop();
    }
}
