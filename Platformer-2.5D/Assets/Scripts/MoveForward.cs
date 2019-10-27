using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RoundBearGames
{

    [CreateAssetMenu(fileName = "New State", menuName = "RoundBearGames/Ability/MoveForward")]
    public class MoveForward : StateDataScriptableObject
    {

        public float Speed;
        public override void UpdateAbility(CharacterState characterState, Animator animator)
        {


            CharacterControl control = characterState.GetCharacterControl(animator);

            if (control.MoveRight && control.MoveLeft)
            {
                animator.SetBool(TransitionParameter.Move.ToString(), false);
                return;

            }


            if (!control.MoveRight && !control.MoveLeft)
            {
                animator.SetBool(TransitionParameter.Move.ToString(), false);
                return;
            }





            /////////////////////////////////////////////////movement script////////////////////////////////////////////
            if (control.MoveRight)
            {
                //move the player
                control.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                //turn face 
                control.transform.rotation = Quaternion.Euler(0f, 0f, 0f);

            }


            if (control.MoveLeft)
            {
                //move the player
                control.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                //turn face to 180 degree
                control.transform.rotation = Quaternion.Euler(0f, 180f, 0f);

            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////





        }

    }




}

