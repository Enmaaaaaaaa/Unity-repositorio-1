using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class condicional : MonoBehaviour
{
    public int edadUno = 5;
    public float edadDos = 3.6f;

    public int miSobrante = 5 % 2;






    // Start is called before the first frame update
    void Start()
    {
        if (edadUno >= 3.6f)
        {
            Debug.Log("EdadUno es mayor que 3.6");
        }
        else
        {
            Debug.Log("EdadUno es menor que 3.6");
        }
        if (miSobrante == 0)
        {
            Debug.Log("El sobrante es par");

        }
        else
        {
            Debug.Log("El sobrante es impar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

