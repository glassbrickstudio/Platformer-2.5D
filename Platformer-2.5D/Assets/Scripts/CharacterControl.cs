using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace RoundBearGames
{

    //enum names to use in animator bools instead of typing 
    public enum TransitionParameter
    {
        Move,

    }


    public class CharacterControl : MonoBehaviour
    {

        public float speed;
        public Animator animator;
        public Material material;
        public bool MoveRight;
        public bool MoveLeft;
                                    






        public void ChangeMaterial()
        {
            if (material == null)
            {
                return;

            }


            Renderer[] arrMaterials = this.gameObject.GetComponentsInChildren<Renderer>();
            foreach (Renderer r in arrMaterials)
            {

                if (r.gameObject != this.gameObject)
                {
                    r.material = material;
                }

            }
        }







    }











}





