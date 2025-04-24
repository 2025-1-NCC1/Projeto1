using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovB : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float velocidade = 10;
    public bool isPaused = false;
    int textojogo1Pontos = 0;
    int textjogo2Pontos = 0;
    public TMP_Text textojogo1;
    public TMP_Text textjogo2;

    void Start()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        GetComponent<Rigidbody>().linearVelocity = new Vector2(velocidade * x, velocidade * y);
        textojogo1.SetText(textojogo1Pontos.ToString());
        textjogo2.SetText(textjogo2Pontos.ToString());
        //Debug.Log("Pontuação Jogador 1:" + textojogo1Pontos);
        //Debug.Log("pontuação Jogador 2:" + textjogo2Pontos);
        if ((textjogo2Pontos > 3) || (textojogo1Pontos > 3))
        {
            SceneManager.LoadScene("Menu");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            Pause();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Esquerda")
        {
            //Jogador 1
            transform.position = new Vector3(0, 0, 0);
            textjogo2Pontos += 2;
            Start();
        }
        else if (collision.gameObject.name == "Direita")
        {
            //Jogador 2
            transform.position = new Vector3(0, 0, 0);
            textojogo1Pontos++;
            Start();
        }
    }

    void Pause()
    {
        if (isPaused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }

    }
}
