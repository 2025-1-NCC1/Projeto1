using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    TMP_Text TextTMP;
    float TimerEnergy = 60f;
    int ValorEnergico;
    public ContadorEnergua Energy1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ValorEnergico = 1000;
        TextTMP = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        TimerEnergy -= Time.deltaTime;
        TextTMP.text = TimerEnergy.ToString();
        if (TimerEnergy <= 0) {
            Energy1.RemoveEnergia(ValorEnergico);

            TimerEnergy = 60f;

            ValorEnergico += 500;
        }
    }
}
