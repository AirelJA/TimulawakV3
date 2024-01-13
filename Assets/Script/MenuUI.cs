using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public TMP_InputField input;
    public TextMeshProUGUI scoreText;

    public string playerName;

    public string inputName;

    public string namePlayer;


    public void OnValueChanged()
    {
        playerName = input.text;
        GameManager.Instance.namainput = playerName;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Start()
    {
        GameManager.Instance.LoadData();
        namePlayer = GameManager.Instance.namePlayer;

        scoreText.text = $"player : {namePlayer}";
    }

    public void StartMain()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        //Application.Quit();

        GameManager.Instance.namePlayer = playerName;
        GameManager.Instance.SaveData();
        EditorApplication.ExitPlaymode();
    }
}
