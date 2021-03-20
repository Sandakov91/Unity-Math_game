using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Slider slider;
    private float time;
    private float timeToAdd;
    private AudioSource timerAudio;
    private bool isTimeRunningOut;

    [SerializeField] private float timerSoundScale;

    void Start()
    {
        slider = GetComponent<Slider>();
        timerAudio = GetComponent<AudioSource>();
        time = GameManager.Instance.MaxTime;
        timeToAdd = time / 4;
    }

    void Update()
    {
        isTimeRunningOut = time <= GameManager.Instance.MaxTime / timerSoundScale;
        if (isTimeRunningOut)
        {
            timerAudio.mute = false;
        }
        else if (!isTimeRunningOut) 
        {
            timerAudio.mute = true;
        }
        if (time <= 0)
        {
            GameManager.Instance.EndGame("You loose");
        }
        time -= Time.deltaTime;
        slider.value = time / GameManager.Instance.MaxTime;
    }
    public void AddTime()
    {
        time += timeToAdd;
        if(time > GameManager.Instance.MaxTime)
        {
            time = GameManager.Instance.MaxTime;
        }
    }
}
