using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject pauseUI, gameOverUI;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Open PAUSE when Click ESCAPE
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseUI.SetActive(true);
        }
    }

    public void OpenGameOverUI()
    {
        gameOverUI.SetActive(true);
    }
}
