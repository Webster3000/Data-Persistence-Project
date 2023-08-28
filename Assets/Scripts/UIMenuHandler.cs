using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMenuHandler : MonoBehaviour
{
    public GameObject inputField;
    public Button playButton;

    public void StartGame()
    {
        StoreName();
        SceneManager.LoadScene(1);
    }

    public void StoreName()
    {
        GameManager.PlayerName = inputField.GetComponent<TMP_InputField>().text;
    }
}
