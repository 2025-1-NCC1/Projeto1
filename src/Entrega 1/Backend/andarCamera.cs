using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movimentoPlay : MonoBehaviour
{
    public float rotationSpeed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0 && transform.position.y < 2209.3f)
        {
            transform.Translate(0.05f, 0, 0);
        }
        else if ((Input.GetAxisRaw("Horizontal") < 0))
        {
            transform.Translate(-0.05f, 0, 0);
        }
        else if ((Input.GetAxisRaw("Vertical") < 0))
        {
            transform.Translate(0, 0, -0.05f);
        }
        else if ((Input.GetAxisRaw("Vertical") > 0))
        {
            transform.Translate(0, 0, 0.05f);

        }
    }
}
