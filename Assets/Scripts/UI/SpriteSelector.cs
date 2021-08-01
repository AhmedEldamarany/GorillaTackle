using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSelector : MonoBehaviour
{
    [SerializeField] intSO SpritesSO;
    [SerializeField] Sprite[] Balls;
    [SerializeField] SpriteRenderer[] images;
    void Start()
    {
        foreach (SpriteRenderer image in images)
            image.sprite = Balls[SpritesSO.value];
    }

   
}
