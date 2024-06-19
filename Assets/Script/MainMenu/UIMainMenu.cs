using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private Button playButton, exitButton;
    void Start()
    {
        playButton.onClick.AddListener(ChangeToGameplay);
        exitButton.onClick.AddListener(ExitGame);
    }
    void ChangeToGameplay()
    {
        SceneManager.LoadScene("Gameplay");
    }

    void ExitGame()
    {
        Application.Quit();
    }
}
