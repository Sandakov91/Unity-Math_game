using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private AudioClip buttonClip;
    public void PlayButtonSound()
    {
        SoundManager.Instance.PlaySound(buttonClip);
    }
    public void StartLevel(string difficulty)
    {
        DifficultyManager.Instance.SetDifficulty(difficulty);
        SceneManager.LoadScene("MainScene");
    }
    public void ExitToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
