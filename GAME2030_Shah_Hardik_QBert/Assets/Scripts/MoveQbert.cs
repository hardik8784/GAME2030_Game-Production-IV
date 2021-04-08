using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveQbert : MonoBehaviour
{
    public string midJump = "No";
    public AudioSource DieSound;
    public AudioClip QbertDies;

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
            GameFlow.RemainingLives -= 1;
            Debug.Log("RemainingLives :" + GameFlow.RemainingLives.ToString());
            DieSound.clip = QbertDies;
            DieSound.Play();
        }

        if(other.tag == "Right_Top")
        {
            transform.eulerAngles = new Vector3(0, -180, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 4, -1);
            GetComponent<Rigidbody>().position = new Vector3(0, 0.5f, 0);
            DelayMove();
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }

        if(other.tag == "Left_Top")
        {
            transform.eulerAngles = new Vector3(0, -270, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(1, 4, 0);
            GetComponent<Rigidbody>().position = new Vector3(0, 0.5f, 0);
            DelayMove();
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
    }



    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Cube")
        {
            StartCoroutine(DelayMove()); 
        }
    
        if(other.gameObject.tag == "Green_Ball")
        {
            GameFlow.PauseBoard = "Yes";
            StartCoroutine(DelayPause());  
        }

        if(other.gameObject.tag == "Red_Ball" || other.gameObject.tag == "Coily_Ball" || other.gameObject.tag == "Coily")
        {
                transform.eulerAngles = new Vector3(0, -90, 0);
                GetComponent<Rigidbody>().velocity = new Vector3(-1, 6, 0);
            
           
        }
    }

    

    IEnumerator DelayMove()
    {
        yield return new WaitForSeconds(0.1f);
        midJump = "No";
    }


    IEnumerator DelayPause()
    {
        yield return new WaitForSeconds(0.1f);
        GameFlow.PauseBoard = "No";
    }

}


