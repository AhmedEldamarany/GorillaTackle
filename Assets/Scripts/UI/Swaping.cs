using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swaping : MonoBehaviour
{
    [SerializeField] Sprite[] sprites;
    Image image;
    int index = 0;
    void Start()
    {
        image = GetComponent<Image>();
    }

    public void SwapImages()
    {
        index++;
        image.sprite = sprites[index % 2];
    }
}
