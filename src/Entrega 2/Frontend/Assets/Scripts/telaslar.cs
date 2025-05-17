using UnityEngine;
using TMPro;
public class telaslar : MonoBehaviour
{
    public string targetTag = "EnergyGiver"; // Defina a tag que deseja detectar

    public TMP_Text pontosEnergy;

    private void Start()
    {
        InvokeRepeating("Espera", 5, 5);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Botão esquerdo do mouse
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("enersolar")) // Verifica a tag
                {

                    pontosEnergy.GetComponent<ContadorEnergua>().AddEnergia(5);
                    Debug.Log("Energia: "); // Mostra no Console
                }
            }
        }
    }

    void Espera()
    {
        pontosEnergy.GetComponent<ContadorEnergua>().AddEnergia(1);
    }
}
//