using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneObject : MonoBehaviour
{
    public GameObject Cubito; 

    public void CloneCube()
    {
        int contador = 1;
        while (contador < 4)
        {
            Instantiate(Cubito);
            contador++;
        }
    }
}
