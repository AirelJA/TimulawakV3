using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public TMP_InputField input;

    public string playerName;

    public string inputName;

    public string namePlayer;


    public void OnValueChanged()
    {
        playerName = input.text;
        GameManager.Instance.namaInput = playerName;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Start()
    {
        /*GameManager.Instance.LoadData();*/
        namePlayer = GameManager.Instance.namePlayer;

    }

    public void StartMain()
    {
        GameManager.Instance.namePlayer = playerName;
        GameManager.Instance.SaveData();
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
        //EditorApplication.ExitPlaymode();
    }
}