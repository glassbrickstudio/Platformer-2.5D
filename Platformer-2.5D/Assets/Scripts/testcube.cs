using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace RoundBearGames
{

    


    public class testcube : MonoBehaviour
    {

        public float speed;
        // Update is called once per frame
        void Update()
        {

            if (VirtualInputManager.Instance.MoveRight && VirtualInputManager.Instance.MoveLeft)
            {
                return;

            }

            if (VirtualInputManager.Instance.MoveRight)
            {
                //move the player
                this.gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);

                //turn face 
                this.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }


            if (VirtualInputManager.Instance.MoveLeft)
            {
                //move the player
                this.gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);

                //turn face to 180 degree
                this.gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            }

        }












    }











}





