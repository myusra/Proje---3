using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 vect3;
    void Start()
    {
        vect3 = new Vector3(0, 0.3f, 0);
    }

    
    void Update()
    {
        transform.Rotate(vect3);
    }
}
