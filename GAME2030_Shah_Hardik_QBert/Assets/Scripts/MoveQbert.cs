using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveQbert : MonoBehaviour
{
    public string midJump = "No";
    public AudioSource DieSound;
    public AudioClip QbertDies;

    //public GameObject CurseImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow) && (midJump == "No"))
        {
            midJump = "Yes";
            transform.eulerAngles = new Vector3(0, -180 , 0);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 4, -1);
           

        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && (midJump == "No"))
        {
            midJump = "Yes";
            transform.eulerAngles = new Vector3(0, -360, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 6, 1);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && (midJump == "No"))
        {
            midJump = "Yes";
            transform.eulerAngles = new Vector3(0, -270, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(1, 4, 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && (midJump == "No"))
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
            //for (int i = 0; i < 500; i++)
            //{
            //    Instantiate(CurseImage, new Vector3(this.transform.position.x + 0.5f, this.transform.position.y + 1.5f, this.transform.position.z), Quaternion.identity);
            //    //CurseImage = Instantiate(CurseImage, new Vector3(this.transform.position.x + 0.5f, this.transform.position.y + 1.5f, this.transform.position.z), Quaternion.identity);
            //    //Debug.Log(i);
            //}
            //CurseImage = Instantiate(CurseImage, new Vector3( 1000.0f, this.transform.position.y + 1.5f, this.transform.position.z), Quaternion.identity);

            //    for (int i = 0; i < 50; i++)
            //    {

            //    CurseImage = Instantiate(CurseImage, new Vector3(this.transform.position.x + 0.5f, this.transform.position.y + 1.5f, this.transform.position.z), Quaternion.identity);
            //    CurseImage.SetActive(true);
            //    }
            //CurseImage.SetActive(false);
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


