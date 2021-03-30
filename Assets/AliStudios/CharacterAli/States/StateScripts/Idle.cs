using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace alistudios
{
    [CreateAssetMenu(fileName = "New State", menuName = "alistudios/abilityData/Idle")]
    public class Idle : StateData
    {
        public override void updateAbility(CharacterState characterState, Animator animator)
        {
             // when Right button is pressed 
            if (VirtualInputManager.Instance.MoveRight)
            {
                animator.SetBool(CharacterController.TransitionParameters.Move.ToString(), true);
            }

            // when left button is pressed 
            if (VirtualInputManager.Instance.MoveLeft)
            {
                 // for player movement to left 
                animator.SetBool(CharacterController.TransitionParameters.Move.ToString(), true);
            }
        }

    }

}