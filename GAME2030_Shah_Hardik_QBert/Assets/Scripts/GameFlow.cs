using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameFlow : MonoBehaviour
{
    public static int RemainingTiles = 28;
    public Transform Red_Ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(RemainingTiles == 0)
        {
            Debug.Log("You Win");
            StartCoroutine(loadNextLevel());
        }
    }

    IEnumerator loadNextLevel()
    {
        yield return new WaitForSeconds(5);
        RemainingTiles = 28;
        SceneManager.LoadScene("SampleScene");
        //SceneManager.LoadScene("Win State");
    }

}
