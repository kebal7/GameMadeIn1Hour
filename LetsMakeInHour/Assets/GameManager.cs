using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject spawner;
    public GameObject gameOverCanvas;
    public GameObject mainMenuCanvas;
    // Start is called before the first frame update
    void Awake()
    {
        Time.timeScale = 0;
        mainMenuCanvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play()
    {
        mainMenuCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    public void EndGame()
    {
        Time.timeScale = 0f;
        spawner.SetActive(false);
        gameOverCanvas.SetActive(true);
    }

    public void Restart()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
