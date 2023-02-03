using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaludPersonaje : MonoBehaviour
{
   public int vidaSalud = 100;
    public int dañoProyectil = 30;

    // Start is called before the first frame update
    void Start()
    {
        saludRestante();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void saludRestante()
    {
        int SaludPersonaje = vidaSalud - dañoProyectil;
        Debug.Log("La vida del personaje tras el impacto es: " + SaludPersonaje);
    }
}
