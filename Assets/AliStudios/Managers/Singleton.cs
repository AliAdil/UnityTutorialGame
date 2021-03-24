using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace alistudios
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        // One instance
        private static T _instance;

        //Public variable which is generic T
        public static T Instance
        {
            get
            {
                _instance = (T)FindObjectOfType(typeof(T));
                if(_instance == null)
                {
                    GameObject obj = new GameObject();
                    _instance = obj.AddComponent<T>();
                    obj.name  = typeof(T).ToString();
                
                }
                return _instance;
            }

        }
    }
}