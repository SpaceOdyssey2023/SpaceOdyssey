using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombRock : MonoBehaviour
{
    public float destroyDelay = 1f;
    private bool isDestroyed = false;

    public ParticleSystem destroyParticle;

    public AudioSource destroyAudio;
    public GameObject modelGameObject;

    public void Destroy()
    {
        if (!isDestroyed)
            return;
        isDestroyed = true;

        destroyParticle.Play();
        destroyAudio.Play();

        modelGameObject.SetActive(false);

        Destroy(gameObject, destroyDelay);
            
    }

}
