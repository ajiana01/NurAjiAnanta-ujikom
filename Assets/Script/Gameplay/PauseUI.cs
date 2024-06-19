using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseUI : MonoBehaviour
{
    [SerializeField] private Button resumeButton, mainMenuButton;
    void Start()
    {
        Time.timeScale = 0;
        resumeButton.onClick.AddListener(ResumeGame);
        mainMenuButton.onClick.AddListener(GoToMainMenu);
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }

    void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
