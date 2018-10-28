using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundEffectBase : MonoBehaviour {

    public AudioSource ReproduzirAudio;

    public void ExecutarEfeito()
    {
        if (!ReproduzirAudio.isPlaying)
            ReproduzirAudio.Play();
    }
}
