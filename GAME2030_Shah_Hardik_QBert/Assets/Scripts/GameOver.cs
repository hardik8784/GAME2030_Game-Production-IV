using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(BackToStart());
    }

    IEnumerator BackToStart()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Start");
    }
}
