using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class bullet : MonoBehaviour
{
    

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    

        int randomInt = Random.Range(85, 95);

        transform.eulerAngles = new Vector3(0, randomInt * -1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
        rb.AddForce(transform.forward *100f, ForceMode.Force);



    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wall")
        {

            Destroy(this.gameObject);


        }

        if (collision.gameObject.tag == "player2")
        {

            Destroy(this.gameObject);


        }

        if (collision.gameObject.tag == "player1")
        {
          
          
            
            //stanui.stungage += 20;
            //stanui.slider.value = stanui.stungage;
        }

        if (collision.gameObject.tag == "player2")
        {
           
            
            
            stan2p.stungage2p += 20;
            stan2p.slider2p.value = stan2p.stungage2p;
        }
    }
}
