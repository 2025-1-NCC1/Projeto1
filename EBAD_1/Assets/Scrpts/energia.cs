using UnityEngine;
using UnityEngine.UI;

public class EnergyUIManager : MonoBehaviour
{
    [Header("Referências de UI")]
    public GameObject menuPanel;       // Arraste aqui o MenuPanel
    public GameObject energyPanel;     // Arraste aqui o EnergyPanel
    public Text energyText;            // Arraste aqui o TxtEnergyValue

    private int energia = 0;

    void Start()
    {
        // Garante que o painel de energia comece oculto
        menuPanel.SetActive(true);
        energyPanel.SetActive(false);
        UpdateEnergyText();
    }

    // Chamado pelo BtnOpenEnergy.OnClick()
    public void ShowEnergyScreen()
    {
        menuPanel.SetActive(false);
        energyPanel.SetActive(true);
    }

    // Chamado pelo BtnCloseEnergy.OnClick()
    public void HideEnergyScreen()
    {
        energyPanel.SetActive(false);
        menuPanel.SetActive(true);
    }

    // Chamado pelo BtnAddEnergy.OnClick()
    public void AddEnergy()
    {
        energia += 1;
        UpdateEnergyText();
    }

    private void UpdateEnergyText()
    {
        energyText.text = "Energia: " + energia;
    }
}
