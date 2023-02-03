using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstanteVariable : MonoBehaviour
{
    //La cantidad de salud
    public int saludPersonaje = 100;
    //El deterio de salud
    public int deterioroSalud = 10;

    public string nombrePersonaje = "Robin";


      // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("Salud inicial: " + saludPersonaje);

        Debug.Log("Daño que recibe: " + deterioroSalud);
        Debug.Log(saludPersonaje - deterioroSalud);
        Debug.Log("El nombre del personaje es: " + nombrePersonaje);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
