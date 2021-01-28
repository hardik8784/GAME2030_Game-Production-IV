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
        if(Input.GetKeyDown("7"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 4, -1);
        }

        if (Input.GetKeyDown("9"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 6, 1);
        }

        if (Input.GetKeyDown("1"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(1, 4, 0);
        }

        if (Input.GetKeyDown("3"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-1, 6, 0);
        }


    }
}
