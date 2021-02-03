using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visability : MonoBehaviour
{
    SpriteRenderer rend;
    
   // public float targetTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        rend = this.gameObject.GetComponent<SpriteRenderer>();

    }
    // Update is called once per frame
    void Update()
    {
        //targetTime += Time.deltaTime;
       
        //if (targetTime > 0.0f)
        //{
            rend.enabled = !rend.enabled;
        //}
    }
}

