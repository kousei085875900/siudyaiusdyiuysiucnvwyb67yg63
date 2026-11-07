using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguroContriller : MonoBehaviour
{
    public float speed = 2000;
    // Start is called before the first frame update
    void Start()
    {
        shoot(new Vector3(speed, 200, 0));
    }
    public void shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit");
        GetComponent<Rigidbody>().isKinematic = true;
        StartCoroutine(time());


    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator time()
    {
        GetComponent<ParticleSystem>().Play();
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
