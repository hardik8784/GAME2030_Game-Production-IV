using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{

    public GameObject Leaderboard;


    void Start()
    {
        Leaderboard.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GoToMain()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }

    public void GoToLeaderBoard()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        // UnityEngine.SceneManagement.SceneManager.LoadScene("LeaderBoard", LoadSceneMode.Single);
        Leaderboard.SetActive(true);
    }

    public void GoToExit()
    {
        Application.Quit();
    }

    public void GoToStart()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        UnityEngine.SceneManagement.SceneManager.LoadScene("Start", LoadSceneMode.Single);
    }

    public void LeaderBoardToMain()
    {
        Leaderboard.SetActive(false);
    }
}
