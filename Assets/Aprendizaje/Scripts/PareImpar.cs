using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PareImpar: MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.Text componenteTexto = null;

    private string dato1; 
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IngresaDato1(string ingreso)
    {
        dato1 = ingreso;
        Debug.Log(dato1);
    }

    public void AlgoritmoEjercicio()
    {
        int entero = int.Parse(dato1);
        int restoDivision = entero % 2;
        string resultado;


        if (restoDivision == 0)
        {
            resultado = "es par";
        }
        else
        {
            resultado = "es impar";
        }

        componenteTexto.text = resultado;
    }
}
