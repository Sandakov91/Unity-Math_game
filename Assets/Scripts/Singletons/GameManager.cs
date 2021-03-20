using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private float maxTime = 30;
    public List<Button> Buttons { get; private set; }
    public Timer Timer { get; private set; }
    public float MaxTime => maxTime;
    private void Awake()
    {
        Instance = this;
        Buttons = new List<Button>();
        Timer = FindObjectOfType<Timer>();
        Buttons.AddRange(FindObjectsOfType<Button>());
    }
    public void EndGame(string message)
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
    }

}
