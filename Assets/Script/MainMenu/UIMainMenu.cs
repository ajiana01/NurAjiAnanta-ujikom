using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private Button playButton, exitButton;
    [SerializeField] private AudioSource _audioSorce;
    void Start()
    {
        playButton.onClick.AddListener(ChangeToGameplay);
        exitButton.onClick.AddListener(ExitGame);
    }
    void ChangeToGameplay()
    {
        _audioSorce.Play();
        SceneManager.LoadScene("Gameplay");
    }

    void ExitGame()
    {
        _audioSorce.Play();
        Application.Quit();
    }
}
