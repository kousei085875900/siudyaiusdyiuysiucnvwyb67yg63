using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stagestete : MonoBehaviour
{
    public GameObject allBlocks;
    public GameObject ball;
    public GameObject player;
   // public GameObject panelOnStageClear;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isClear=true;
        foreach(Transform Blocks in allBlocks.transform)
        {
            if (Blocks.childCount != 0)
            {
            isClear = false;
            }


        }
        /*if (isClear==true)
        {

            OnStageClear();
        }
        */
    }
   /* public void OnStageClear()
    {
        panelOnStageClear.SetActive(true);

    }
  */
}
