using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    public GameObject GameOverScreen;
    public GameObject NextStageScreen;
    public static MainManager Instance;

    //public TextMeshProUGUI gameoverText;
    //public Button restartButton;
    public string namePlayer;
    public string namaInput;

    public static bool isGameOver;
    public static bool isNextStage;

    public void Awake()
    {

        /*if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);*/

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
        /*if (SceneManager.GetActiveScene().name == "Level1")
        {
            GameOverScreen = GameObject.Find("GameOverScreen");
            GameOverScreen = GameObject.Find("NextStageScreen");
        }*/

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