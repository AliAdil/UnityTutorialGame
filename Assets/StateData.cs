using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace alistudios
{
    public abstract class StateData : ScriptableObject
    {
        public float Duration;

        public abstract void updateAbility(CharacterStateBase characterStateBase, Animator animator);
    }
}
