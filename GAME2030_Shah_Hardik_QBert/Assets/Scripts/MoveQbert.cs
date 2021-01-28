using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveQbert : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("1"))
        {
            transform.eulerAngles = new Vector3(0, -180 , 0);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 4, -1);
        }

        if (Input.GetKeyDown("9"))
        {
            transform.eulerAngles = new Vector3(0, -360, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 6, 1);
        }

        if (Input.GetKeyDown("3"))
        {
            transform.eulerAngles = new Vector3(0, -270, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(1, 4, 0);
        }

        if (Input.GetKeyDown("7"))
        {
            transform.eulerAngles = new Vector3(0, -90, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(-1, 6, 0);
        }


    }
}
