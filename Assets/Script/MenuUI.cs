using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public TMP_InputField input;
    public TMP_Text errorMessageText; // Add this line
    public string playerName;
    public string inputName;
    public string namePlayer;

    public void OnValueChanged()
    {
        playerName = input.text;
        GameManager.Instance.namaInput = playerName;
    }

    private void Start()
    {
         //GameManager.Instance.LoadData();
         namePlayer = GameManager.Instance.namePlayer;
    }

    public void StartMain()
    {
        // Check if the input field is empty
        if (string.IsNullOrEmpty(playerName))
        {
            // Show an error message on the UI
            errorMessageText.text = "Please fill the input field first.";
            return;
        }

        // If the input field is not empty, proceed to start the game
        GameManager.Instance.namePlayer = playerName;
        GameManager.Instance.SaveData();
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        //Application.Quit();
        EditorApplication.ExitPlaymode();
    }
}