using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LanguageSwapping : MonoBehaviour
{
    [SerializeField] intSO LanguageSO;
    string english1 = "You have ";
    string english2 = " points";
    string russian1 = "У ВАС ЕСТЬ ";
    string russian2 = " ОЧКОВ";
    [SerializeField] TMP_Text message;
    [SerializeField] intSO ScoreSO;

    void Start()
    {
        swapMessage();
    }

    public void swapMessage()
    {
        if (LanguageSO.value == 0)
            message.text = $"{russian1} {ScoreSO.value}  {russian2}";
        else
            message.text = $"{english1} {ScoreSO.value}  {english2}";
    }
    public void SwapLanguage()
    {
        if (LanguageSO.value == 0)
            LanguageSO.value = 1;
        else
            LanguageSO.value = 0;
    }
}

