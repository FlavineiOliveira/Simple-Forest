using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireParticle : ParticleBase {

    void Start () {

        ReproduzirAudio.loop = true;	
	}
	
	void Update () {

        ExecutarEfeito();
    }
}
