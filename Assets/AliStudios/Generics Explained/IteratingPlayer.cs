using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IterationgPlayer : MonoBehaviour
{
    public List<int> intList = new List<int>();
    public List<string> stringList = new List<string>();

    public void IterateThrough<T>(List<T> targetList)
    {
        foreach (T data in targetList)
        {
            Debug.Log(data);
        }
    }
}
