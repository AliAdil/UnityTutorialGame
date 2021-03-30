using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace alistudios
{

    // Inherited Character Statemachine in our customClass 
    public class CharacterStateBase : StateMachineBehaviour
    {
        // Start is called before the first frame update
        //Encapsulation 
        // Private variable for characterController Script
        private CharacterController characterController;

        // Get Method of character controller private variable
        public CharacterController GetCharacterController(Animator animator)
        {
            if (characterController == null)
            {
                characterController = animator.GetComponentInParent<CharacterController>();
               
            }
           return characterController;
        }
    }
}
