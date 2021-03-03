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
        GameObject QbertReference = GameObject.FindWithTag("Qbert");
        //if(QbertReference)
        //{
        //    Vector3 QbertPosition = new Vector3 (QbertReference.transform.position.x, QbertReference.transform.position.y, QbertReference.transform.position.z);
        //    GetComponent<Rigidbody>().position = new Vector3(QbertPosition.x, QbertPosition.y, QbertPosition.z);
        //    //Vector3 TargetPosition = new Vector3 (QbertPosition.x, QbertPosition.y, QbertPosition.z);
        //   // Debug.Log("Target Position: " + TargetPosition);
        //}

        if (QbertReference.transform.position.y < 0 && QbertReference.transform.position.z < 0)
        {
            transform.eulerAngles = new Vector3(0, -180, 0);
           
            transform.eulerAngles = new Vector3(0, -180, 0);
            for (int i = 0; i < 6; i++)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(0, -i, -i);
            }

                //CoilyJump = "Yes";
                //transform.eulerAngles = new Vector3(0, -180, 0);
                //for(int i = 0; i < 6; i++)
                //{
                //    GetComponent<Rigidbody>().velocity = new Vector3(0, -i, -i);

                //    if(QbertReference.transform.position == GetComponent<Rigidbody>().position )
                //    {
                //        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                //    }
                //   // transform.position = new Vector3(0, 1 * Time.deltaTime, 1 * Time.deltaTime);
                //}
                //CoilyJump = "No";
                //GetComponent<Rigidbody>().velocity = new Vector3(0, 4, -1);
                // transform.position += new Vector3(0 , 1* Time.deltaTime, 1 * Time.deltaTime);
                //transform.position = new Vector3(0, 1 * Time.deltaTime, 1 * Time.deltaTime);

            }

        if (QbertReference.transform.position.x > 0 && QbertReference.transform.position.y < 0 )
        {
            
            transform.eulerAngles = new Vector3(0, -270, 0);
            for (int i = 0; i < 6; i++)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(i, -i, -i);
            }

            GetComponent<Rigidbody>().velocity = new Vector3(1, 4, 0);
        }

        if (Input.GetKeyDown("a") )
        {
            transform.eulerAngles = new Vector3(0, -360, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 6, 1);
        }

        if (Input.GetKeyDown("s"))
        {
           
            transform.eulerAngles = new Vector3(0, -270, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(1, 4, 0);
        }

        if (Input.GetKeyDown("d") )
        {
          
            transform.eulerAngles = new Vector3(0, -90, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(-1, 6, 0);
        }
    }

}
