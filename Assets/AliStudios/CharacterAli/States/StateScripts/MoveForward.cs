using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace alistudios
{
    [CreateAssetMenu(fileName = "New State", menuName = "alistudios/abilityData/MoveForward")]
    public class MoveForward : StateData
    {
        // for speed we define variable here
        public float speed;
        public override void updateAbility(CharacterState characterState, Animator animator)
        {
             //getting charactercontroller form characterStateBase

             CharacterController c = characterState.GetCharacterController(animator);
             
              // When pressed both button
            if (VirtualInputManager.Instance.MoveLeft && VirtualInputManager.Instance.MoveRight)
            {
                // Setting animation to idle state
                animator.SetBool(CharacterController.TransitionParameters.Move.ToString(), false);
                return;
            }

            // when no button is pressed 
            if (!VirtualInputManager.Instance.MoveLeft && !VirtualInputManager.Instance.MoveRight)
            { // Setting animation to idle state
                animator.SetBool(CharacterController.TransitionParameters.Move.ToString(), false);
                return;
            }
            // when Right button is pressed 
            if (VirtualInputManager.Instance.MoveRight)
            {
                // for player movement to right
                c.transform.Translate(Vector3.forward * speed * Time.deltaTime);
                // turn player face on right
                // Euler(X,Y,Z) axis
                c.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }


            // when left button is pressed 
            if (VirtualInputManager.Instance.MoveLeft)
            {
                // for player movement to left 
                c.transform.Translate(Vector3.forward * speed * Time.deltaTime);
                // turn player face on left 
                c.transform.rotation = Quaternion.Euler(0f, 180f, 0f);

            }
        }
    }
}
