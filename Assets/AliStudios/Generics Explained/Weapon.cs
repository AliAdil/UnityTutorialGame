using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon <T> : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void className()
    {
        Debug.Log("I am Generic Class for weapons "+ typeof(T));
    }
}
