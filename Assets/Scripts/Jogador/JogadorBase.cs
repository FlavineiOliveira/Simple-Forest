using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class JogadorBase : MonoBehaviour {

    public CharacterController MovimentacaoControlador;
    public Camera DirecaoCamera; 

    public float velocidadeDeslocamento;

	public void Andar()
    {
        Vector3 direcao = DirecaoCamera.transform.TransformDirection(Vector3.forward);
        MovimentacaoControlador.Move(direcao);
    }
}
