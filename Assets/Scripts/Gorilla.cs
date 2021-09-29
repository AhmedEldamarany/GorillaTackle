using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gorilla : MonoBehaviour
{
    
    public Transform Arrow;
    [SerializeField] Transform leftArm;
    [SerializeField] Transform righttArm;
    Vector3 offset = new Vector3(.5f, 0, 0);
    [SerializeField] GameObject Arms;
    Animator anim;
    [SerializeField] HandsCollsion handsCollsion;
    Touch touch;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void ShowArms(bool show)
    {
        Arms.SetActive(show);
        if (show) handsCollsion.canCollide = true;
        else handsCollsion.canCollide = false;
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
            {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
            {
                anim.SetTrigger("reach");
                leftArm.position = Arrow.position - offset;
                righttArm.position = Arrow.position + offset;
            }
            else
            {
                anim.ResetTrigger("score");
                anim.ResetTrigger("foul");

            }

        }
    }
   
   
}
