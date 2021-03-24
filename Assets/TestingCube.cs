using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace alistudios
{
    public class TestingCube : MonoBehaviour
    {
        void Update()
        {
            if (VirtualInputManager.Instance.MoveLeft && VirtualInputManager.Instance.MoveRight)
            {
                return;
            }
            if (VirtualInputManager.Instance.MoveRight)
            {   // for player movement to right
                this.gameObject.transform.Translate(Vector3.forward * 10f * Time.deltaTime);
                // turn player face on right
                // Euler(X,Y,Z) axis
                this.gameObject.transform.rotation = Quaternion.Euler(0f,0f,0f);
            }

            if (VirtualInputManager.Instance.MoveLeft)
            {
                // for player movement to left 
                this.gameObject.transform.Translate(Vector3.forward * 10f * Time.deltaTime);
                // turn player face on left 
                this.gameObject.transform.rotation = Quaternion.Euler(0f,180f,0f);
            }
        }

    }
}
