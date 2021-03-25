using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace alistudios
{
    public class CharacterController : MonoBehaviour
    {
        public enum TransitionParameters
        {
            Move,
            MoveStandardWalk,
            MoveStrutWalk,
            MoveWalking,

        }


        public float Speed;
        public Animator animator;
        void Update()
        {

            // When pressed both button
            if (VirtualInputManager.Instance.MoveLeft && VirtualInputManager.Instance.MoveRight)
            {

                // Setting animation to idle state
                animator.SetBool(TransitionParameters.Move.ToString(), false);
                animator.SetBool(TransitionParameters.MoveStandardWalk.ToString(), false);
                animator.SetBool(TransitionParameters.MoveStrutWalk.ToString(), false);
                animator.SetBool(TransitionParameters.MoveWalking.ToString(), false);
                return;
            }

            // when no button is pressed 
            if (!VirtualInputManager.Instance.MoveLeft && !VirtualInputManager.Instance.MoveRight)
            { // Setting animation to idle state
                animator.SetBool(TransitionParameters.Move.ToString(), false);
                animator.SetBool(TransitionParameters.MoveStandardWalk.ToString(), false);
                animator.SetBool(TransitionParameters.MoveStrutWalk.ToString(), false);
                animator.SetBool(TransitionParameters.MoveWalking.ToString(), false);
            }

            // when Right button is pressed 
            if (VirtualInputManager.Instance.MoveRight)
            {

                // for player movement to right
                this.gameObject.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                // turn player face on right
                // Euler(X,Y,Z) axis
                this.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                // Setting animation into moving state

                if (Input.GetKey(KeyCode.D))
                {
                 
                    animator.SetBool(TransitionParameters.Move.ToString(), true);
                    animator.SetBool(TransitionParameters.MoveStandardWalk.ToString(), false);
                    animator.SetBool(TransitionParameters.MoveStrutWalk.ToString(), false);
                    animator.SetBool(TransitionParameters.MoveWalking.ToString(), false);
                }

                if (Input.GetKey(KeyCode.C))
                {
                   
                    animator.SetBool(TransitionParameters.Move.ToString(), false);
                    animator.SetBool(TransitionParameters.MoveStandardWalk.ToString(), true);
                    animator.SetBool(TransitionParameters.MoveStrutWalk.ToString(), false);
                    animator.SetBool(TransitionParameters.MoveWalking.ToString(), false);
                }

                if (Input.GetKey(KeyCode.E))
                {
                   
                    animator.SetBool(TransitionParameters.Move.ToString(), false);
                    animator.SetBool(TransitionParameters.MoveStandardWalk.ToString(), false);
                    animator.SetBool(TransitionParameters.MoveStrutWalk.ToString(), true);
                    animator.SetBool(TransitionParameters.MoveWalking.ToString(), false);
                }

                if (Input.GetKey(KeyCode.N))
                {
              
                    animator.SetBool(TransitionParameters.Move.ToString(), false);
                    animator.SetBool(TransitionParameters.MoveStandardWalk.ToString(), false);
                    animator.SetBool(TransitionParameters.MoveStrutWalk.ToString(), false);
                    animator.SetBool(TransitionParameters.MoveWalking.ToString(), true);
                }


            }


            // when left button is pressed 
            if (VirtualInputManager.Instance.MoveLeft)
            {
                // for player movement to left 
                this.gameObject.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                // turn player face on left 
                this.gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                // Setting animation into moving state

                if (Input.GetKey(KeyCode.A))
                {
                  
                    animator.SetBool(TransitionParameters.Move.ToString(), true);
                    animator.SetBool(TransitionParameters.MoveStandardWalk.ToString(), false);
                    animator.SetBool(TransitionParameters.MoveStrutWalk.ToString(), false);
                    animator.SetBool(TransitionParameters.MoveWalking.ToString(), false);

                }

                if (Input.GetKey(KeyCode.Z))
                {
                   
                    animator.SetBool(TransitionParameters.Move.ToString(), false);
                    animator.SetBool(TransitionParameters.MoveStandardWalk.ToString(), true);
                    animator.SetBool(TransitionParameters.MoveStrutWalk.ToString(), false);
                    animator.SetBool(TransitionParameters.MoveWalking.ToString(), false);

                }

                if (Input.GetKey(KeyCode.Q))
                {
                   
                    animator.SetBool(TransitionParameters.Move.ToString(), false);
                    animator.SetBool(TransitionParameters.MoveStandardWalk.ToString(), false);
                    animator.SetBool(TransitionParameters.MoveStrutWalk.ToString(), true);
                    animator.SetBool(TransitionParameters.MoveWalking.ToString(), false);

                }

                if (Input.GetKey(KeyCode.V))
                {
                   
                    animator.SetBool(TransitionParameters.Move.ToString(), false);
                    animator.SetBool(TransitionParameters.MoveStandardWalk.ToString(), false);
                    animator.SetBool(TransitionParameters.MoveStrutWalk.ToString(), false);
                    animator.SetBool(TransitionParameters.MoveWalking.ToString(), true);

                }
            }
        }

    }
}
