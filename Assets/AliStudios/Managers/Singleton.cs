using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace alistudios
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        // Private Variable 
        private static T _instance;

        //Public static method
        public static T Instance
        { 
            get
            {
                _instance = (T)FindObjectOfType(typeof(T));
                if(_instance == null)
                {
                    // Creating empty gameobject in the scene
                    GameObject obj = new GameObject();
                    // to that game object we are attacting singleton game script
                    _instance = obj.AddComponent<T>();
                    // Renaming that gameobject same as singleton script
                    obj.name  = typeof(T).ToString();
                
                }
                return _instance;
            }

        }
    }
}