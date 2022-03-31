using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchConString : MonoBehaviour
{
    public string curso;
    // Start is called before the first frame update
    void Start()
    {
        switch (curso)
        {
            case "A":
                Debug.Log("33 alumnos");
                break;
            case "B":
                Debug.Log("31 alumnos");
                break;
            case "C":
                Debug.Log("30 alumnos");
                break;
            default:
                Debug.Log("No existe ese curso");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
