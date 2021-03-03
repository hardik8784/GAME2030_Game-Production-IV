using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoilyControl : MonoBehaviour
{

    public string CoilyJump = "No";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject QbertReference = GameObject.FindWithTag("Qbert");

        //if (QbertReference.transform.position.y < 0 && QbertReference.transform.position.z < 0)
        //{
        //    //transform.eulerAngles = new Vector3(0, -180, 0);
        //    //for (int i = 0; i < 6; i++)
        //    //{
        //    //    GetComponent<Rigidbody>().velocity = new Vector3(0, -i, -i);
        //    //}
        //    if (Random.Range(0, 2) == 0)
        //    {
        //        GetComponent<Rigidbody>().velocity = new Vector3(0, 4, -1);
        //    }
        //    else
        //    {
        //        GetComponent<Rigidbody>().velocity = new Vector3(1, 4, 0);
        //    }
        //}

        //if (QbertReference.transform.position.x > 0 && QbertReference.transform.position.y < 0 )
        //{
        //    if (Random.Range(0, 2) == 0)
        //    {
        //        GetComponent<Rigidbody>().velocity = new Vector3(0, 4, -1);
        //    }
        //    else
        //    {
        //        GetComponent<Rigidbody>().velocity = new Vector3(1, 4, 0);
        //    }

        //    //transform.eulerAngles = new Vector3(0, -270, 0);
        //    //for (int i = 0; i < 6; i++)
        //    //{
        //    //    GetComponent<Rigidbody>().velocity = new Vector3(i, -i, -i);
        //    //}
        //}

        //if(QbertReference.transform.position.x < 6  && QbertReference.transform.position.y < -6)
        //{
        //    //transform.eulerAngles = new Vector3(0, -90, 0);

        //    //for (int i = 6; i < 0; i--)
        //    //{
        //    //    GetComponent<Rigidbody>().velocity = new Vector3(i, -i, 0);
        //    //}

        //    if (Random.Range(0, 2) == 0)
        //    {
        //        GetComponent<Rigidbody>().velocity = new Vector3(0, 4, -1);
        //    }
        //    else
        //    {
        //        GetComponent<Rigidbody>().velocity = new Vector3(1, 4, 0);
        //    }
        //}

        //if (QbertReference.transform.position.y < -6 && QbertReference.transform.position.z < -6)
        //{
        //    //transform.eulerAngles = new Vector3(0, -360, 0);
        //    //for (int i = 0; i < 6; i++)
        //    //{
        //    //    GetComponent<Rigidbody>().velocity = new Vector3(i, -i, -i);
        //    //}
        //    if (Random.Range(0, 2) == 0)
        //    {
        //        GetComponent<Rigidbody>().velocity = new Vector3(0, 4, -1);
        //    }
        //    else
        //    {
        //        GetComponent<Rigidbody>().velocity = new Vector3(1, 4, 0);
        //    }
        //}

        
    }

    private void OnCollisionEnter(Collision other)
    {
        GameObject QbertReference = GameObject.FindWithTag("Qbert");
        //if(Random.Range(0,2) == 0 )
        //{
        //    GetComponent<Rigidbody>().velocity = new Vector3(0, 6, 1);
        //}
        //else
        //{
        //    GetComponent<Rigidbody>().velocity = new Vector3(-1, 6, 0);
        //}
        if(transform.position.x == QbertReference.transform.position.x || transform.position.y > QbertReference.transform.position.y || transform.position.z > QbertReference.transform.position.z)
        {
            transform.eulerAngles = new Vector3(0, -180, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 4, -1);
        }

        if(transform.position.x < QbertReference.transform.position.x || transform.position.y > QbertReference.transform.position.y || transform.position.z == QbertReference.transform.position.z)
        {
            transform.eulerAngles = new Vector3(0, -270, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(1, 4, 0);
        }

        if(transform.position.x > QbertReference.transform.position.x || transform.position.y < QbertReference.transform.position.y || transform.position.z == QbertReference.transform.position.z)
        {
            transform.eulerAngles = new Vector3(0, -90, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(-1, 6, 0);
        }

        if(transform.position.x == QbertReference.transform.position.x || transform.position.y < QbertReference.transform.position.y || transform.position.z < QbertReference.transform.position.z)
        {
            transform.eulerAngles = new Vector3(0, -360, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 6, 1);
        }
    }

}
