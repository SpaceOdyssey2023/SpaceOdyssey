using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public AudioClip hitSound;  // sound when player is damaged
    private AudioSource hurtAudioPlayer;  // audio source component

    public void Awake()
    {
        // get using component from game object
        hurtAudioPlayer = GetComponent<AudioSource>();
    }

    public void OnDamage(float damage, Vector3 hitPoint, Vector3 hitNormal)
    {
        if (!dead)  // if player isn't dead
        {
            hurtAudioPlayer.PlayOneShot(hitSound);
        }
    }
}
