using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockThrow : MonoBehaviour
{
    public GameObject throw_1;
    public GameObject throw_2;
    public GameObject throw_3;
    private static float count;

    private bool flag ;

    private static float holdtime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
         flag = true;
        }

        if(Input.GetKeyUp(KeyCode.F))
        {
         Debug.Log(holdtime);
         
         flag = false;
        }

        if(flag)
        {
            holdtime += Time.deltaTime;
        }

        if(flag == false)
        {
            holdtime=0;
        }

      
    }
}
