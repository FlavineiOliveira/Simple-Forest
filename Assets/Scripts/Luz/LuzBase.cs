using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Light))]
public class LuzBase : MonoBehaviour {

    public Light LuzesFogueira;
    private bool intervaloRange = false;

    public void AlternarIntensidadeLuz()
    {
        LuzesFogueira.range = AlternarRange(intervaloRange, (int)LuzesFogueira.range);
    }

    public int AlternarRange(bool valorEstaAumentando, int range)
    {
        if (valorEstaAumentando)
            switch(range)
            {
                case 18:
                    return 19;

                case 19:
                    intervaloRange = false;
                    return 20;
            }

        else if (!valorEstaAumentando)
            switch (range)
            {
                case 19:
                    intervaloRange = true;
                    return 18;

                case 20:
                    return 19;
            }

        return 20;
    }
}
