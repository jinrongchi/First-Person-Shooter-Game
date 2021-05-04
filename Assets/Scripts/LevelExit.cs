using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{
    public string nextLevel;
    public float waitToEndLevel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GameManager.insatance.LevelEnding = true;
            StartCoroutine(EndLevelCo());
            AudioManager.instance.PlayLevelVicotry();
        }
    }

    private IEnumerator EndLevelCo()
    {
        //PlayerPrefs.SetString(nextLevel + "_cp", "");
        yield return new WaitForSeconds(waitToEndLevel);
        SceneManager.LoadScene(nextLevel);
    }
}
