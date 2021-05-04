using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    public string mainMenuScence;
    private string restart;

    // Start is called before the first frame update
    void Start()
    {
        restart = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Resume()
    {
        GameManager.insatance.Pause();
    }

    public void Restart()
    {
        SceneManager.LoadScene(restart);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(mainMenuScence);
    }

}
