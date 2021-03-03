using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoilyBallControl : MonoBehaviour
{
    public Transform Coily;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (Random.Range(0, 2) == 0)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 4, -1);
        }
        else
        {
            GetComponent<Rigidbody>().velocity = new Vector3(1, 4, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Net")
        {
            // GetComponent<Transform>().position = new Vector3(3, -4, -3);
            // GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            Instantiate(Coily, new Vector3(3, -4, -3), Coily.rotation);
        }
    }


}
