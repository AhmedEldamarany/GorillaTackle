﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallSelecting : MonoBehaviour
{
    [SerializeField] int requiredScore;
    [SerializeField] int spriteOrder;
    [SerializeField] intSO scoreSO;
    [SerializeField] intSO sprireSO;
    Image image;
    void Start()
    {
        image = GetComponent<Image>();   
    }
    public void Buy()
    {
        if(scoreSO.value>= requiredScore)
        {
            sprireSO.value = spriteOrder;
            SceneManager.LoadScene(1);
        }

    }
    public void ChangeButton()
    {
        if (scoreSO.value >= requiredScore)
        {
            image.color = Color.clear;
        }
    }
   
}
