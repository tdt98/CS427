using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackDragonScript : MonoBehaviour
{
    Vector2 newPos;
    public float speed = 1.0f;
    public float speedForjump = 1.0f;
    private Rigidbody2D rigidbody;

    private bool isTouchingGround;
    public LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isTouchingGround = IsGrounded();
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddForce(new Vector2(-speed, 0));
            GetComponent<SpriteRenderer>().flipX = true;
           
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddForce(new Vector2(+speed, 0));
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) && isTouchingGround)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, +speedForjump));
        } 
    }
    private bool IsGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1.0f;

        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null)
        {
            return true;
        }

        return false;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
    }

}
