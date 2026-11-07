using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class player : MonoBehaviour
{
    // Start is called before the first frame update
    private float accel = 1000.0f;
    
    void Start()
    {
      
    }

    // Update is called once per frame

    stanui test;


    public enum playertype { player1_wasd, player2_arrows, player2_ijkl }
    public enum who { player1, player2, none}
    public playertype playerType;
    public who www;
    public float speed = 5f;
    private Rigidbody rb;
    private KeyConfig currentkeys;
    private struct KeyConfig
    {
        public KeyCode up,down,left,right;

        public KeyConfig(KeyCode u, KeyCode d, KeyCode l, KeyCode r)
        {
            up = u;
            down = d;
            left = l;
            right = r;

        }
    }
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        switch (playerType)
        {
            case playertype.player1_wasd:
                currentkeys = new KeyConfig(KeyCode.W, KeyCode.S, KeyCode.A, KeyCode.D);
                break;
            case playertype.player2_arrows:
                currentkeys = new KeyConfig(KeyCode.UpArrow, KeyCode.DownArrow, KeyCode.LeftArrow, KeyCode.RightArrow);
                break;
            case playertype.player2_ijkl:
                currentkeys = new KeyConfig(KeyCode.I, KeyCode.K, KeyCode.J, KeyCode.L);
                break;
        }
    }
    private void FixedUpdate()
    {
        if (www == who.player1)
        {
            if(stanui.stun_on_off == false)
            {
                Vector3 moveInput = Vector3.zero;

            if (Input.GetKey(currentkeys.up)) moveInput.x = -1;
            if (Input.GetKey(currentkeys.down)) moveInput.x = 1;
            if (Input.GetKey(currentkeys.left)) moveInput.z = -1;
            if (Input.GetKey(currentkeys.right)) moveInput.z = 1;

            if (playerType == playertype.player2_arrows || playerType == playertype.player2_ijkl)
            {
                moveInput.x = -moveInput.x;
                moveInput.z = -moveInput.z;
            }

            if (rb != null)
            {
                rb.velocity = new Vector3(moveInput.x * speed, rb.velocity.y, moveInput.z * speed);
            }
                
            }
            
        }

        if (www == who.player2)
        {
            if (stan2p.stun_on_off2p == false)
            {
                Vector3 moveInput = Vector3.zero;

            if (Input.GetKey(currentkeys.up)) moveInput.x = -1;
            if (Input.GetKey(currentkeys.down)) moveInput.x = 1;
            if (Input.GetKey(currentkeys.left)) moveInput.z = -1;
            if (Input.GetKey(currentkeys.right)) moveInput.z = 1;

            if (playerType == playertype.player2_arrows || playerType == playertype.player2_ijkl)
            {
                moveInput.x = -moveInput.x;
                moveInput.z = -moveInput.z;
            }

            if (rb != null)
            {
                rb.velocity = new Vector3(moveInput.x * speed, rb.velocity.y, moveInput.z * speed);
            }
            }

            
            
        }



    }

}

