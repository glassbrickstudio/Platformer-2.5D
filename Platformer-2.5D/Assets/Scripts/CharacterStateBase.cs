using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//script to get the character control from the statemachine
namespace RoundBearGames
{

    public class CharacterStateBase : StateMachineBehaviour
    {

        private CharacterControl characterControl;
        public CharacterControl GetCharacterControl(Animator animator)
        {
            if (characterControl == null)
            {
                characterControl = animator.GetComponentInParent<CharacterControl>();

            }
            return characterControl;

        }






    }














}








