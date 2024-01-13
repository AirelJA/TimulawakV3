using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NameManager : MonoBehaviour
{

    public TextMeshProUGUI nameDisplay;

    // Start is called before the first frame update
    void Start()
    {
        nameDisplay.text = GameManager.Instance.namePlayer;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
