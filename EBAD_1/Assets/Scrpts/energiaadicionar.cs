using UnityEngine;
using UnityEngine.UI;

public class ControleCorrupcao : MonoBehaviour
{
    public Slider barraCorrupcao;
    private float nivelCorrupcao;
    public float maxCorrupcao = 100f;
    public float minCorrupcao = 0f;

    void Start()
    {
        // Inicializa o nível de corrupção no valor mínimo
        nivelCorrupcao = minCorrupcao;
        AtualizarBarraCorrupcao();
    }

    // Método para aumentar a corrupção
    public void AumentarCorrupcao(float quantidade)
    {
        nivelCorrupcao += quantidade;
        if (nivelCorrupcao > maxCorrupcao)
        {
            nivelCorrupcao = maxCorrupcao;
        }
        AtualizarBarraCorrupcao();
    }

    // Método para diminuir a corrupção
    public void DiminuirCorrupcao(float quantidade)
    {
        nivelCorrupcao -= quantidade;
        if (nivelCorrupcao < minCorrupcao)
        {
            nivelCorrupcao = minCorrupcao;
        }
        AtualizarBarraCorrupcao();
    }

    // Atualiza o valor do Slider para refletir o nível de corrupção atual
    private void AtualizarBarraCorrupcao()
    {
        barraCorrupcao.value = nivelCorrupcao;
    }
}
