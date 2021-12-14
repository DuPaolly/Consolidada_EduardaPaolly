using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geral : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] Transform objetoReferencia;
    [SerializeField] 

    public void BotaoPato()
    {
        GameObject objetoInstanciado = Instantiate(prefab, objetoReferencia.position, objetoReferencia.rotation);
        Destroy(objetoInstanciado, 2);
    }
}
