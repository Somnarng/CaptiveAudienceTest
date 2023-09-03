using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;

    float horizontal;
    float vertical;

    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnDisable()
    {
        rb.velocity = new Vector2 (0,0);
    }
//sets velocity to 0 on disable for player switch
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2((horizontal * speed)* Time.deltaTime, (vertical * speed) * Time.deltaTime);
    }//moves rb by horizontal + vert input
}