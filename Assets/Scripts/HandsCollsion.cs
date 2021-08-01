using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsCollsion : MonoBehaviour
{
    string teamMateTag="teamMate";
    string OpponontTag="enemy";
    [HideInInspector] public bool canCollide;
   [SerializeField] Animator anim;
    [SerializeField] TickToc ticTok;
    [SerializeField] SFX sfx;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!canCollide)
            return;
        canCollide = false;
        if (collision.CompareTag(teamMateTag))
        {
            anim.SetTrigger("foul");
            collision.gameObject.GetComponent<PlayerMovment>().Die();
            sfx.InfectingSfx();
           
        }
        else if (collision.CompareTag(OpponontTag))
        {
            anim.SetTrigger("score");
            collision.gameObject.GetComponent<PlayerMovment>().Die();
            ticTok.IncreaseScore();
            sfx.HealingSfx();

        }



    }

}
