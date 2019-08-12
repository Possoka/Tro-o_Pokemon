using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_pokemonB : MonoBehaviour
{
    public float BDamage = 0f;    
    public float BVida = 0f;

    public Src_pokemonA pokeA;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            BVida = BVida - pokeA.ADamage;
            Debug.Log(BVida.ToString());
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            pokeA.AVida = pokeA.AVida - BDamage;
            Debug.Log(pokeA.AVida.ToString());
        }

        if (BVida == 0)
        {
            Debug.Log("O Pokemon B morreu");
        }

        if (pokeA.AVida == 0)
        {
            Debug.Log("O pokemon A morreu");
        }
    }
}
