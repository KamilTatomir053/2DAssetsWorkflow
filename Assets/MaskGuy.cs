using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskGuy : MonoBehaviour
{
    public Rigidbody2D rb;

    public float speed;

    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void LateUpdate()
    {
        rb.velocity = movement;

        movement = Vector2.zero;
    }

    public void Left()
    {
        movement = Vector2.left * speed;
    }

    public void Right()
    {
        movement = Vector2.right * speed;
    }

    public void Up()
    {
        movement = Vector2.up * speed;
    }

    public void Down()
    {
        movement = Vector2.down * speed;
    }
}
