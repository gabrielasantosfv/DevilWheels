using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcenCarreteras : MonoBehaviour
{
    public GameObject motorCarretera;
    public MotorCarreteras motorCarreterasScript;
    public GameObject coche;

    void OnTriggerEnter2D(Collider2D cInfo)
    {
        if(cInfo.gameObject.tag == "Coche")
        {
            motorCarreterasScript.SpeedArcen();
            coche.GetComponent<AudioSource>().pitch = 1f;
        }
    }

    void OnTriggerExit2D(Collider2D cInfo)
    {
        if(cInfo.gameObject.tag == "Coche")
        {
            motorCarreterasScript.SpeedCarretera();
            coche.GetComponent<AudioSource>().pitch = 1.6f;
        }
    }
}
