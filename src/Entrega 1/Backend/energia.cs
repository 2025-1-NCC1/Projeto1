using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnergyUIManager : MonoBehaviour
{
    [Header("Referências de UI")]
    [SerializeField] GameObject menuPanel;       // Arraste aqui o MenuPanel
    [SerializeField] GameObject energyPanel;     // Arraste aqui o EnergyPanel
    [SerializeField] TextMeshProUGUI energyText;            // Arraste aqui o TxtEnergyValue
    [SerializeField] Button EnergyButton;       // Arraste aqui o EnergyButton

    int energia = 0;

    private void Awake()
    {
        EnergyButton.onClick.AddListener(AddEnergy);
    }
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
        if (energia < 1000)
        {
            energia += 1;
            UpdateEnergyText();
        }
    }

    private void UpdateEnergyText()
    {
        energyText.text = "Energia: " + energia;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse button
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("EnergyGiver")) // Or use tag, or compare the actual GameObject
                {
                    AddEnergy();
                }
            }
        }
    }

}
