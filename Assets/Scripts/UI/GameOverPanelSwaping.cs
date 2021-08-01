using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverPanelSwaping : MonoBehaviour
{
    [SerializeField] Sprite english;
    [SerializeField] Sprite russian;
    [SerializeField] intSO LanguageSO;

    Image image;

        void Start()
    {
        image = GetComponent<Image>();
        if (LanguageSO.value == 0)
            image.sprite = russian;
        else
            image.sprite = english;
    }

   
}
