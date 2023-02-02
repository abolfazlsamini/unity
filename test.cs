using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // why it not work when you change it to an even number inside unity?
    public int velos = 0;
    int x = 1;
    
    void Update()
    {
        
        x = velos *x;
        transform.rotation = Quaternion.Euler( new Vector3(x,0,0));
    
    }
}
