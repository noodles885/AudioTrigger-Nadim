using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySFX : MonoBehaviour
{
    public AudioSource SFX;

    private void OnTriggerEnter(Collider other)
    {

        SFX.Play();

    }




}
