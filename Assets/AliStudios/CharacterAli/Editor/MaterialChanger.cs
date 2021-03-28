using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


namespace alistudios
{

    //Creates a custom Label on the inspector for all the scripts named CharacterController
    [CustomEditor(typeof(CharacterController))]
    public class MaterialChanger : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            CharacterController control = (CharacterController)target;

            if (GUILayout.Button("Change Material"))
            {
                control.ChangeMaterial();
            }

        }
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    // Start is called before the first frame update



}


