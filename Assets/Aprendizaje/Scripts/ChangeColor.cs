using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            this.GetComponent<SpriteRenderer>().color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            this.GetComponent<SpriteRenderer>().color = Color.yellow;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            this.GetComponent<SpriteRenderer>().color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            this.GetComponent<SpriteRenderer>().color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            this.GetComponent<SpriteRenderer>().color = Color.magenta;
        }
    }
}
