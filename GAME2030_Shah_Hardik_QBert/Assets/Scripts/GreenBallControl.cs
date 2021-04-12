﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBallControl : MonoBehaviour
{
    public AudioSource PickupSound;
    public AudioClip GreenBallPickupSound;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameFlow.PauseBoard == "Yes")
        {
            Destroy(gameObject);
        }
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
        if (other.tag == "Qbert")
        {
            for(int i = 0; i<50000;i++)
            {
                Time.timeScale = 0;
                Debug.Log(i);
            }
            //Time.timeScale = 0;
            //StartCoroutine(waitsome());

            Time.timeScale = 1;

            GameFlow.Player_Score += 100;
            Debug.Log("Collect the Green_Ball : " + GameFlow.Player_Score.ToString());
            PickupSound.clip = GreenBallPickupSound;
            PickupSound.Play();
        }
    }

    IEnumerator waitsome()
    {
        yield return new WaitForSeconds(5);
    }
}