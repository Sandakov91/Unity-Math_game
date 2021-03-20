using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    public static DifficultyManager Instance { get; private set; }
    public string Difficulty { get; private set; }
    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(this);
    }
    public void SetDifficulty(string difficulty)
    {
        Difficulty = difficulty;
    }
}
