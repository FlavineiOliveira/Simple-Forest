using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class ParticleBase : MonoBehaviour
{
    public ParticleSystem SistemaParticula;

    public AudioClip EfeitoParticula;

    public AudioSource ReproduzirAudio;

    public void ExecutarEfeito()
    {
        if (SistemaParticula.particleCount > 10 && !ReproduzirAudio.isPlaying)
        {
            ReproduzirAudio.PlayOneShot(EfeitoParticula);
        }
    }
}
