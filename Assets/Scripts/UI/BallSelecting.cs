using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallSelecting : MonoBehaviour
{
    [SerializeField] int requiredScore;
    [SerializeField] int spriteOrder;
    [SerializeField] intSO scoreSO;
    [SerializeField] intSO sprireSO;
    Image image;
    [SerializeField] SFX sfx;
    void Start()
    {
        image = GetComponent<Image>();   
    }
    public void Buy()
    {
        if(scoreSO.value>= requiredScore)
        {
            sprireSO.value = spriteOrder;
            sfx.HealingSfx();
            
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
