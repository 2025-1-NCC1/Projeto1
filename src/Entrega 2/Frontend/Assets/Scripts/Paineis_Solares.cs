using UnityEngine;
using Unity.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Paineis_Solares : MonoBehaviour
{
    public GameObject Contador;
    public int indice;
    public List<GameObject> solares = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Libera_Painel()
    {
        if (Contador.GetComponent<ContadorEnergua>().energia >= 50)
        {
            Contador.GetComponent<ContadorEnergua>().energia -= 50;
            solares[indice].SetActive(true);
            indice++;
        }
    }
}
