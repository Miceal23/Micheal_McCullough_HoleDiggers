using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseMenu;

    public bool isPaused;

    public void Start()
    {
        pauseMenu.SetActive(false);
    }

    public void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }

            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0.0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
        isPaused = false; 
    }
}
