using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace alistudios
{
    public class CharacterStateBase : StateMachineBehaviour
    {
        // Start is called before the first frame update

        private CharacterController characterController;
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
