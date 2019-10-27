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
                                    





        // Update is called once per frame
        void Update()
        {

            if (VirtualInputManager.Instance.MoveRight && VirtualInputManager.Instance.MoveLeft)
            {
                animator.SetBool(TransitionParameter.Move.ToString(), false);
                return;

            }


            if (!VirtualInputManager.Instance.MoveRight && !VirtualInputManager.Instance.MoveLeft)
            {
                animator.SetBool(TransitionParameter.Move.ToString(), false);
            }






            if (VirtualInputManager.Instance.MoveRight)
            {
                //move the player
                this.gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);
                //turn face 
                this.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                animator.SetBool(TransitionParameter.Move.ToString(), true);
            }


            if (VirtualInputManager.Instance.MoveLeft)
            {
                //move the player
                this.gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);
                //turn face to 180 degree
                this.gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                animator.SetBool(TransitionParameter.Move.ToString(), true);
            }

        }










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





