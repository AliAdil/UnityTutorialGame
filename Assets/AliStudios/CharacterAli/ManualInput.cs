using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace alistudios
{
    public class ManualInput : MonoBehaviour
    {
        // Start is called before the first frame update

        private CharacterController characterController;
        void Awake()
        {

            characterController = this.gameObject.GetComponent<CharacterController>();
        }

        // Update is called once per frame
        void Update()
        {
            if (VirtualInputManager.Instance.MoveRight)
            {
                characterController.moveRight = true;
            }
            else
            {
                characterController.moveRight = false;
            }
            
            if (VirtualInputManager.Instance.MoveLeft)
            {
                characterController.moveLeft = true;
            }
            else
            {
                characterController.moveLeft = false;
            }


        }
    }
}
