using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverScreen;
    public static GameManager Instance;

    //public TextMeshProUGUI gameoverText;
    //public Button restartButton;

    public static bool isGameOver;

    public void Awake()
    {
        isGameOver = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            GameOverScreen.SetActive(true);
        }
    }

    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StageComplete()
    {
        SceneManager.LoadScene(+1);
    }
}
