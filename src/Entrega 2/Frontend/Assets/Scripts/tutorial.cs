using UnityEngine;

public class tutorial : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private GameObject tutor;

    public void tuto()
    {
        tutor.SetActive(false);
    }
}
