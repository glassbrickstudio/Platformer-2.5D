using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace RoundBearGames
{
    [CreateAssetMenu(fileName = "New State", menuName = "RoundBearGames/Ability/Idle")]
    public class Idle : StateDataScriptableObject
    {

        public override void UpdateAbility(CharacterState characterState, Animator animator)
        {
            /////////////////////////////////////////////////movement script////////////////////////////////////////////
            if (VirtualInputManager.Instance.MoveRight)
            {


                animator.SetBool(TransitionParameter.Move.ToString(), true);
            }


            if (VirtualInputManager.Instance.MoveLeft)
            {

                animator.SetBool(TransitionParameter.Move.ToString(), true);
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }

    }


}
