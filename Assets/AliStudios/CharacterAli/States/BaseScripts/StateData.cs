using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace alistudios
{
    public abstract class StateData : ScriptableObject
    {
        public float Duration;

        public abstract void onEnter(CharacterState characterState, Animator animator);
        public abstract void updateAbility(CharacterState characterState, Animator animator);
        public abstract void onExit(CharacterState characterState, Animator animator);
    }
}
