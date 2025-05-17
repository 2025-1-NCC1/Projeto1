using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
    [SerializeField] Button ButtonGameOver;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ButtonGameOver.onClick.AddListener(Click);
    }

    void Click()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
