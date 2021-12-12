using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public float speedX;
    public float speedY;
    public GameObject tp;
    private Vector3 vector;
    private Rigidbody2D myRigidbody;
    private Animator animator;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animator.SetFloat("MoveX", 0);
        animator.SetFloat("MoveY", -1);
    }

    void FixedUpdate()
    {
        vector = Vector3.zero;
        vector.x = speedX;
        vector.y = speedY;
        transform.position += new Vector3(speedX, speedY, 0) * Time.deltaTime * 1;
        UpdateAnimationAndMoving();
    }
    void UpdateAnimationAndMoving()
    {
        if (vector != Vector3.zero)
        {
            animator.SetFloat("MoveX", vector.x);
            animator.SetFloat("MoveY", vector.y);
            animator.SetBool("move", true);
        }
        else
        {
            animator.SetBool("move", false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "tptp")
        {
            SceneManager.LoadScene(3);
        }
    }


    public void MoveUp()
    {
        speedY = 10;
    }
    public void MoveDown()
    {
        speedY = -10;
    }
    public void MoveRight()
    {
        speedX = 10;
    }
    public void MoveLeft()
    {
        speedX = -10;
    }
    public void Stop()
    {
        speedX = 0;
        speedY = 0;
    }
}
