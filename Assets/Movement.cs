using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    GameObject Personaje;
    // Start is called before the first frame update
    void Start()
    {
        if (Time.time == 2)
        {
            GameObject.Destroy(Personaje);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
