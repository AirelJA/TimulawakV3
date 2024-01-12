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
    public GameObject NextStageScreen;
    public static GameManager Instance;

    //public TextMeshProUGUI gameoverText;
    //public Button restartButton;

    public static bool isGameOver;
    public static bool isNextStage;

    public void Awake()
    {
        isGameOver = false;
        isNextStage = false;
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

        if (isNextStage)
        {
            NextStageScreen.SetActive(true);
        }
    }

    

    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void StageComplete()
    {
        SceneManager.LoadScene(2);
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
