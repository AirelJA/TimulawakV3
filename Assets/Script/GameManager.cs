using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
    public string namePlayer;
    public string namaInput;

    public static bool isGameOver;
    public static bool isNextStage;

    public void Awake()
    {
        isGameOver = false;
        isNextStage = false;

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

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

    public void SaveData()
    {
        SaveData data = new SaveData();
        data.namePlayer = namePlayer;

        //if want to add another data to json file
        // data.PlayerName = PlayerName //to save player name

        string json = JsonUtility.ToJson(data);

        //File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
        string path = GetSaveFilePath();
        File.WriteAllText(path, json);
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

    /*public void LoadData()
    {
        //string path = Application.persistentDataPath + "/savefile.json";
        string path = GetSaveFilePath();

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            namePlayer = data.namePlayer;
        }
    }*/

    private string GetSaveFilePath()
    {
        string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string gameFolder = Path.Combine(documentsPath, "UCP2");

        // Create the game folder if it doesn't exist
        if (!Directory.Exists(gameFolder))
        {
            Directory.CreateDirectory(gameFolder);
        }

        // Append the file name to the game folder path
        return Path.Combine(gameFolder, "Savefile.json");
    }
}

[Serializable]
public class SaveData
{
    public string namePlayer;
    // add the variable that want to save
    //ex:
    // public string Playername //to save playername
}