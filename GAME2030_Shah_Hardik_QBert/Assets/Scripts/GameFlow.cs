using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameFlow : MonoBehaviour
{
    public static int RemainingTiles = 28;
    public Transform Red_Ball;
    public Transform Green_Ball;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRedBall());
        StartCoroutine(SpawnGreenBall());
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
        SceneManager.LoadScene("Start");
        //SceneManager.LoadScene("Win State");
    }

    IEnumerator SpawnRedBall()
    {
        yield return new WaitForSeconds(4);
        Instantiate(Red_Ball, new Vector3(0, 2, -1), Red_Ball.rotation);
        StartCoroutine(SpawnRedBall());
    }

    IEnumerator SpawnGreenBall()
    {
        yield return new WaitForSeconds(7);
        Instantiate(Green_Ball, new Vector3(1, 2, 0), Green_Ball.rotation);
        StartCoroutine(SpawnGreenBall());
    }

}
