using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace alistudios
{

    // Inherited Character Statemachine in our customClass 
    public class CharacterState : StateMachineBehaviour
    {

        public List<StateData> ListAbilityData = new List<StateData>();

        public void UpdateAll(CharacterState characterState, Animator animator)
        {
            foreach (StateData d in ListAbilityData)
            {
                d.updateAbility(characterState, animator);
            }
        }
        // Updating every single frame here
        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            UpdateAll(this,animator);
        }

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
