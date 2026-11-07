using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class BallScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20.0f;
    private Rigidbody rb;
    public float maxspeed;
    public int WhereToMoney;
    public Material Material1p;
    public Material Material2p;
    

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1, 0, -1).normalized * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "player1" || collision.gameObject.tag == "player2")
        {
            Rigidbody playerRb = collision.gameObject.GetComponent<Rigidbody>();

            if (playerRb != null)
            {
                Vector3 currentVelocity = rb.velocity;

                float influence = 0.5f;

                currentVelocity.z += playerRb.velocity.z * influence;
                rb.velocity = currentVelocity.normalized * speed;
            }
        }
        else
        {
            rb.velocity = rb.velocity.normalized * speed;
        }
        /*
        if (collision.gameObject.tag == "Block")
        {
            float m = rb.velocity.magnitude;

            float x = rb.velocity.x;
            float z = rb.velocity.z;
            x = x / m;
            z = z / m;
            rb.velocity = new Vector3(x, 0, z) * speed;

        
        */
        if (collision.gameObject.tag == "player1")
        {
            WhereToMoney = 1;
            PlaceBlock.mony += 10;
            transform.GetComponent<Renderer>().material = Material1p;

            if (stanui.stun_on_off == false)
            {
                stanui.stungage += 20;
            }
         
            stanui.slider.value = stanui.stungage;
            
        }

        if (collision.gameObject.tag == "player2")
        {
            WhereToMoney = 2;
            PlaceBlock2.mony2 += 10;
            transform.GetComponent<Renderer>().material = Material2p;
            if (stan2p.stun_on_off2p == false)
            {
                stan2p.stungage2p += 20;
            }
            stan2p.slider2p.value = stan2p.stungage2p;
        }

    }

}
