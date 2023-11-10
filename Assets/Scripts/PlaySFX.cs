using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PlayTheSoundEffects
{
    public class PlaySFX : MonoBehaviour
    {
        public AudioSource SFX;

        private void OnTriggerEnter()
        {

            SFX.Play();
        }

    }
}


