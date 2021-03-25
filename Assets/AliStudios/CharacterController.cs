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
        }

        public float Speed;
        public Animator animator;
        void Update()
        {
            if (VirtualInputManager.Instance.MoveLeft && VirtualInputManager.Instance.MoveRight)
            {
                // Setting animation to idle state
                animator.SetBool(TransitionParameters.Move.ToString(), false);
                return;
            }

            if (!VirtualInputManager.Instance.MoveLeft && !VirtualInputManager.Instance.MoveRight)
            { // Setting animation to idle state
                animator.SetBool(TransitionParameters.Move.ToString(),false);
            }
            if (VirtualInputManager.Instance.MoveRight)
            {   // for player movement to right
                this.gameObject.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                // turn player face on right
                // Euler(X,Y,Z) axis
                this.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                 // Setting animation into moving state
                animator.SetBool(TransitionParameters.Move.ToString(), true);

            }

            if (VirtualInputManager.Instance.MoveLeft)
            {
                // for player movement to left 
                this.gameObject.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                // turn player face on left 
                this.gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                // Setting animation into moving state
                animator.SetBool(TransitionParameters.Move.ToString(), true);
            }
        }

    }
}
