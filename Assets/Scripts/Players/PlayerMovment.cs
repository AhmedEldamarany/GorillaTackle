using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    // Start is called before the first frame update
    float  speed;
    [SerializeField] Transform leftBorder;
    [SerializeField] Transform rightBorder;
   [SerializeField] bool ismovingRight;
    void Start()
    {
        speed = Random.Range(1f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        Run();
    }
    private void FixedUpdate()
    {
        isOutOfBounds();
    }
    public void Run()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0, Space.Self);
    }
    public void FlipFace()
    {
        transform.Rotate(0, 180, 0);
        ismovingRight = !ismovingRight;

    }
    public  void WhenOutOfBounds()
    {
        speed = Random.Range(1f, 5f);
        FlipFace();

    }
    void isOutOfBounds()
    {
        if (ismovingRight)
        { if (transform.position.x > rightBorder.position.x)
                WhenOutOfBounds();}
            else
                if (transform.position.x < leftBorder.position.x)
                WhenOutOfBounds();
    }

   public void Die()
    {
        //gameObject.SetActive(false);
        transform.position = new Vector3 (leftBorder.position.x,transform.position.y,transform.position.z);
        ismovingRight = true;
        transform.rotation = Quaternion.identity;
    }
}

