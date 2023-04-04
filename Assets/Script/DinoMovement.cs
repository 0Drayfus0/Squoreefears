using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoMovement : MonoBehaviour
{
    public float jumpAmount = 20;
    public float speed = 10f;
    Rigidbody2D rb;
    Animator animator;
    Enemy enemy;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        Move();
    }
    private void Move()
    {
        float inputX = Input.GetAxis("Horizontal");

        Vector2 direction = new Vector2(inputX, 0);
        animator.SetFloat("Speed", direction.magnitude);



        if (direction.magnitude > 1)
        {
            direction = direction.normalized;
        }
        rb.velocity = direction * speed;



        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        }
    }
}
