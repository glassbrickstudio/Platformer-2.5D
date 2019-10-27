using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//script to get the character control from the statemachine
namespace RoundBearGames
{

    public class CharacterState : StateMachineBehaviour
    {

        public List<StateDataScriptableObject> ListAbilityData = new List<StateDataScriptableObject>();


        /// //////////////UPDATE function 
        ///////////////////////////////
        public void UpdateAll(CharacterState characterState, Animator animator)
        {
            foreach (StateDataScriptableObject d in ListAbilityData)
            {
                d.UpdateAbility(characterState, animator);

            }

        }


        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            UpdateAll(this,animator);
        }

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








