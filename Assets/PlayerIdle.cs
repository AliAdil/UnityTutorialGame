using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace alistudios
{
    public class PlayerIdle : CharacterStateBase
    {
        // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
           
       
        }

        // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
        override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {


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
               
            }

           


            
        }

        // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
       
        }

      
    }
}
