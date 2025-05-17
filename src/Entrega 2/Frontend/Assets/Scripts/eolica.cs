using UnityEngine;
using TMPro;
public class eolica : MonoBehaviour
{
    // Defina a tag que deseja detectar

    public int energia;
    public GameObject contador;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        contador = GameObject.FindGameObjectWithTag("ContadorEnergia");
        InvokeRepeating("PedeAdd", 5, 5);
    }

    // Update is called once per frame
   
    private void PedeAdd()
    {
        Debug.Log("Adicionou 30");
        contador.GetComponent<ContadorEnergua>().AddEnergia(energia);
    }
}
