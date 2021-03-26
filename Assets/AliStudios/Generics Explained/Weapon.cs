using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon<T> : MonoBehaviour where T : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        className();
    }

    // Update is called once per frame
    void className()
    {
        Debug.Log("I am Generic Class for weapons " + typeof(T));
        // here we are checking if object is a copy or original 
        if (!this.gameObject.name.Contains("copy"))
        {
            // Creating copy of object that uses this Weapon Generic Class
            GameObject copy = new GameObject();
            copy.name = "copy of a " + typeof(T);

            // Adding Script in Copyobject 
            //It will show error because T could be anything  int float etc
            //we can not attach whatever to gameobject so we need to specify that 
            // T is inherit from monobehaviour  
            //public class Weapon <T> : MonoBehaviour where T: MonoBehaviour
            // Now all T has to  be inherited with monoBehaviour

            copy.AddComponent<T>();
        }



    }
}
