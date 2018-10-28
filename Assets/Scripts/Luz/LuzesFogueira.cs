using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzesFogueira : LuzBase {

    private void Update () {

        StartCoroutine(Aguardar());

        AlternarIntensidadeLuz();
    }

    IEnumerator Aguardar()
    {
        yield return new WaitForSeconds(1);
    }
}
