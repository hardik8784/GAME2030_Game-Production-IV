using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveQbert : MonoBehaviour
{
    public string midJump = "No";


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("1") && (midJump == "No"))
        {
            midJump = "Yes";
            transform.eulerAngles = new Vector3(0, -180 , 0);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 4, -1);
        }

        if (Input.GetKeyDown("9") && (midJump == "No"))
        {
            midJump = "Yes";
            transform.eulerAngles = new Vector3(0, -360, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 6, 1);
        }

        if (Input.GetKeyDown("3") && (midJump == "No"))
        {
            midJump = "Yes";
            transform.eulerAngles = new Vector3(0, -270, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(1, 4, 0);
        }

        if (Input.GetKeyDown("7") && (midJump == "No"))
        {
            midJump = "Yes";
            transform.eulerAngles = new Vector3(0, -90, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(-1, 6, 0);
        }
    }

   private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Net")
        {
            GetComponent <Transform>().position = new Vector3(0, 1, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
    }

    

    private void OnCollisionEnter(Collision other)
    {
        StartCoroutine(DelayMove());
    }

    

    IEnumerator DelayMove()
    {
        yield return new WaitForSeconds(0.1f);
        midJump = "No";
    }

}


