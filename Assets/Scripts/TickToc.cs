using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TickToc : MonoBehaviour
{
    [SerializeField] TMP_Text timerText;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] intSO ScoreSO;
    public float timelimit = 2;
    float currentTime;
    [SerializeField] GameObject GameOverMenu;
     bool Playing = true;
    float startingTime;
    [SerializeField] SFX sfx;
    public static int score = 0; //had to be static 
    private void Start()
    {
        Playing = true;
        startingTime = Time.time;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (!Playing) return;
        currentTime = timelimit * 60 - (Time.time- startingTime);
        timerText.text = $"{currentTime  :0.0}";
        if(currentTime<=0)
        {
            GameOverMenu.SetActive(true);
            GameOverMenu.GetComponentInChildren<TMP_Text>().text =$"{ ScoreSO.value}";
            Time.timeScale = 0;
            sfx.GameOver();
        }
    }
    public void isPlaying(bool isPlaying)
    {
        Playing = isPlaying;
        startingTime = Time.time;

    }
    public void setTimeLimit(float tl)
    {
        timelimit = tl;
    }
    public void IncreaseTimeLimit()
    {
        timelimit=((timelimit*60.0f)+1)/60.0f;
    }
     public void InitTimeScale()
    {
        Time.timeScale = 1;
    }
    public void FreezeTime()
    {
        Time.timeScale = 0;
    }
    public  void IncreaseScore()
    {
        score += 10;
        ScoreSO.value = score;
        scoreText.text = $"{score}";
    }
}
