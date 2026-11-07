using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceBlock : MonoBehaviour
{
    
    public GameObject put;
    public GameObject put_lvl2;
    public GameObject put_lvl3;
    public GameObject bulet;
    public int init;
    public static int mony;

    // Start is called before the first frame update
    void Start()
    {
        mony = init;
    }

    // Update is called once per frame
    void Update()
    {
        
       if(stanui.stun_on_off == false)
       {
             if (Input.GetKeyDown(KeyCode.E))
            {
                if (mony >= 10)
                {
                 Instantiate(put, (transform.position), Quaternion.identity);
                 mony -= 10;
                }   

            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                if (mony >= 20)
                {
                 Instantiate(put_lvl2, (transform.position), Quaternion.identity);
                 mony -= 20;
                }
            
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                if (mony >= 30)
                {
                 Instantiate(put_lvl3, (transform.position), Quaternion.identity);
                     mony -= 30;    
                }

            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                if (mony >= 30)
                {       
                Instantiate(bulet, (transform.position), Quaternion.identity);
                Instantiate(bulet, (transform.position), Quaternion.identity);
                Instantiate(bulet, (transform.position), Quaternion.identity);
                mony -= 30;    
                }

            }
       }
    }
}
