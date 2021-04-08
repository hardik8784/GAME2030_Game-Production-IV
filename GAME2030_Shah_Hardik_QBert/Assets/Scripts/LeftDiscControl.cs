using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftDiscControl : MonoBehaviour
{
    public AudioSource ElevatorSound;
    public AudioClip LeftDiscSound;
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
        GetComponent<Rigidbody>().velocity = new Vector3(0, 2, 2);
        ElevatorSound.clip = LeftDiscSound;
        ElevatorSound.Play();
    }
}
