using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private float horizontal;
    private float vertical;
    private Rigidbody2D rb;
    private bool isFacingRight = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        Debug.Log(horizontal);


        vertical = Input.GetAxis("Vertical");
        Debug.Log(vertical);

        this.rb.velocity = new Vector2(horizontal * 8f,rb.velocity.y);

        Flip();


        /*
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Apertou espaço");
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clicou no butaozin");
        }
        */
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
