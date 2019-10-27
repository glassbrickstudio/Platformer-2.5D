using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RoundBearGames
{



    public class ManualInput : MonoBehaviour
    {

        private CharacterControl characterControl;

        private void Awake()
        {
            characterControl = this.gameObject.GetComponent<CharacterControl>();
        }





        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            if (VirtualInputManager.Instance.MoveRight)
            {
                characterControl.MoveRight = true;

            }
            else
            {
                characterControl.MoveRight = false;

            }

            if (VirtualInputManager.Instance.MoveLeft)
            {
                characterControl.MoveLeft = true;

            }
            else
            {
                characterControl.MoveLeft = false;

            }

        }
    }









}
