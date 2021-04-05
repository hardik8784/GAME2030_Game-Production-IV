using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    public Material YellowColour;
    public int ColourStatus = 1;
    public AudioClip Qbert_Land;
   

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
        if (other.gameObject.tag == "Qbert")
        {
            ColourStatus -= 1;
            if (ColourStatus == 0)
            {
                GetComponent<Renderer>().material = YellowColour;
                GameFlow.RemainingTiles -= 1;
                GameFlow.Player_Score += 25;
                Debug.Log("Player changing the Cube : " + GameFlow.Player_Score.ToString());
            }

            if(ColourStatus < 0 )
            {
                ColourStatus = 0;
            }
        }
    }
}
