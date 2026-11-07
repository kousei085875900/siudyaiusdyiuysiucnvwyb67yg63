using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOC : MonoBehaviour
{

    public GameObject ball;

    public GameObject panelOnGameOver;

    public GameObject boom;

    public GameObject boom2;

    public GameObject boom3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


     void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Ball")
        {
            OnGameOver();
        }
    }
    public void OnGameOver()
    {
        panelOnGameOver.SetActive(true); 
        ball.SetActive(false);
        boom.SetActive(true);
        boom2.SetActive(true);
        boom3.SetActive(true);
    }
}
