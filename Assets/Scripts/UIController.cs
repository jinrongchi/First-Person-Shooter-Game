using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    public Slider healthSlider;
    public Text healthText, ammoText;

    public Image damage;
    public float damageAlpha = .25f, damageFadeSpeed = 2f;

    public GameObject pauseScreen;

    public Image black;
    public float fadeSpeed = 1.5f;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (damage.color.a != 0)
        {
            damage.color = new Color(damage.color.r, damage.color.g, damage.color.b, Mathf.MoveTowards(damage.color.a, 0f, damageFadeSpeed * Time.deltaTime));
        }

        if (!GameManager.insatance.LevelEnding)
        {
            black.color = new Color(black.color.r, black.color.g, black.color.b, Mathf.MoveTowards(black.color.a, 0f, fadeSpeed * Time.deltaTime));
        }
        else
        {
            black.color = new Color(black.color.r, black.color.g, black.color.b, Mathf.MoveTowards(black.color.a, 1f, fadeSpeed * Time.deltaTime));
        }
    }

    public void ShowDamage()
    {
        damage.color = new Color(damage.color.r, damage.color.g, damage.color.b, 0.25f);
    }
}
