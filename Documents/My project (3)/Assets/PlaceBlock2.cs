using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceBlock2 : MonoBehaviour
{

    public static int mony2;
    public GameObject put;
    public GameObject put_lvl2;
    public GameObject put_lvl3;
    public int init;
    public GameObject bulet2;
    // Start is called before the first frame update
    void Start()
    {
        mony2 = init;
    }

    // Update is called once per frame
    void Update()
    {
        if (stan2p.stun_on_off2p == false)
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                if (mony2 >= 10)
                {
                    Instantiate(put, (transform.position), Quaternion.identity);
                    mony2 -= 10;
                }

            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                if (mony2 >= 20)
                {
                    Instantiate(put_lvl2, (transform.position), Quaternion.identity);
                    mony2 -= 20;
                }

            }
            if (Input.GetKeyDown(KeyCode.LeftBracket))
            {
                if (mony2 >= 30)
                {
                    Instantiate(put_lvl3, (transform.position), Quaternion.identity);
                    mony2 -= 30;
                }

            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                if (mony2 >= 30)
                {       
                Instantiate(bulet2, (transform.position), Quaternion.identity);
                Instantiate(bulet2, (transform.position), Quaternion.identity);
                Instantiate(bulet2, (transform.position), Quaternion.identity);
                mony2 -= 30;    
                }

            }
        }

    }
}
