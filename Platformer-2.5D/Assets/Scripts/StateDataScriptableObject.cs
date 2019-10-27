using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace RoundBearGames
{




    public abstract class StateDataScriptableObject : ScriptableObject
    {

       
        public float Duration;

        public abstract void UpdateAbility(CharacterState characterState, Animator animator);




    }






}
