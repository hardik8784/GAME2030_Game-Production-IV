using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    public Material YellowColour;
    public int ColourStatus = 1;
    public AudioSource CubeSounds;
    public AudioClip ChangeColorSound;
    public AudioClip NoColorChangeSound;
    public AudioClip BallSound;
    public AudioClip CoilySound;


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
                CubeSounds.clip = ChangeColorSound;
                CubeSounds.Play();
            }
            else
            {
                CubeSounds.clip = NoColorChangeSound;
                CubeSounds.Play();
            }


            if(ColourStatus < 0 )
            {
                ColourStatus = 0;
            }
        }

        if(other.gameObject.tag == "Red_Ball" || other.gameObject.tag == "Coily_Ball" || other.gameObject.tag == "Green_Ball")
        {
            CubeSounds.clip = BallSound;
            CubeSounds.Play();
        }

        if(other.gameObject.tag == "Coily")
        {
            CubeSounds.clip = CoilySound;
            CubeSounds.Play();
        }
    }
}
