using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VictoryScreen : MonoBehaviour
{
    public string mainMenu;
    public float timeBetweenShowing = 1f;
    public GameObject textBox, menuButton;
    public Image blackScreen;
    public float blackSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowObjectCo());
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        blackScreen.color = new Color(blackScreen.color.r, blackScreen.color.g, blackScreen.color.b, Mathf.MoveTowards(blackScreen.color.a, 0f, blackSpeed * Time.deltaTime));
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(mainMenu);
        
    }

    public IEnumerator ShowObjectCo()
    {
        yield return new WaitForSeconds(timeBetweenShowing);
        textBox.SetActive(true);
        yield return new WaitForSeconds(timeBetweenShowing);
        menuButton.SetActive(true);
    }
}
