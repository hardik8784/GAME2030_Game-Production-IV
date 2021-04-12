using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameFlow : MonoBehaviour
{
    public static int RemainingTiles = 28;
    public Transform Red_Ball;
    public Transform Green_Ball;
    public Transform Coily_Ball;
    public static int RemainingLives = 3;
    public static string PauseBoard = "No";
    public static int Player_Score = 0;
    public TMP_Text Player_ScoreText;

    public GameObject Image1;
    public GameObject Image2;

    public AudioSource WinnerSound;
    public AudioClip Winner;

    // Start is called before the first frame update
    void Start()
    {
        if (!PauseMenu.isPaused)
        {
            StartCoroutine(SpawnRedBall());
            StartCoroutine(SpawnGreenBall());
            //StartCoroutine(SpawnCoilyBall());
            SpawnCoilyBall();
        }   
    }

    // Update is called once per frame
    void Update()
    {
        if(RemainingTiles < 0)
        {
            Debug.Log("You Win");
            WinnerSound.clip = Winner;
            WinnerSound.Play();
            StartCoroutine(loadNextLevel());
        }

        if(RemainingLives == 0)
        {
            StartCoroutine(loadTwoLevel());
        }

        if(RemainingLives == 2)
        {
            Destroy(Image1);
        }

        if (RemainingLives == 1)
        {
            Destroy(Image2);
        }
        Player_ScoreText.text = Player_Score.ToString();
    }

    IEnumerator loadNextLevel()
    {
        yield return new WaitForSeconds(5);
        RemainingTiles = 28;
        Player_Score += 1000;
        Debug.Log("Clear the Level : " + Player_Score.ToString());
        SceneManager.LoadScene("Start");
        Player_Score = 0;
        Debug.Log("Cleared : " + Player_Score.ToString());
        RemainingLives = 3;
        Debug.Log("Remaining Lives Reset : " + RemainingLives.ToString());
        //SceneManager.LoadScene("Win State");
    }

    IEnumerator loadTwoLevel()
    {
        RemainingTiles = 28;
        Player_Score += 1000;
        Debug.Log("Clear the Level : " + Player_Score.ToString());
        
        Player_Score = 0;
        RemainingLives = 3;
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("GameOver");
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

    public void SpawnCoilyBall()
    {
        Instantiate(Coily_Ball, new Vector3(1, 2, -1), Coily_Ball.rotation);
    }
}
