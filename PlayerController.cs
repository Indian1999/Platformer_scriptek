using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float jumpForce = 400f;

    private bool jumping = false;
    private float horizontalMovement;

    private Rigidbody2D rb; // Ebbe a változóba kimentjük a Rigidbody komponensre való hivatkozást

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();        
    }

    void Update()
    {
        // Input.GetAxis("horizontal") float érték [-1; 1] között   szorozzuk 20-szal -> [-20; 20]
        horizontalMovement = Input.GetAxis("Horizontal") * movementSpeed;

        if (horizontalMovement < 0) // Balra mozgunk
        {
            transform.localEulerAngles = new Vector3(0, 180, 0);
        }
        if (horizontalMovement > 0)
        {
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }

        if (Input.GetButtonDown("Jump"))
        {
            jumping = true;
        }
    }

    // Alap beállításoknál 1 másodperc alatt 50-szer fut le
    // A fizika másodpercenként 50-szer számol
    // A FixedUpdate a Rigidbody-val összhangban van
    void FixedUpdate()
    {
        movePlayer(horizontalMovement, jumping);
    }

    void movePlayer(float movement, bool jumping)
    {
        rb.velocity = new Vector2(movement, rb.velocity.y);

        // Ha a jumping igaz és érintkezünk akármivel
        if (jumping && GetComponent<CircleCollider2D>().IsTouchingLayers())
        {
            rb.AddForce(new Vector2(0, jumpForce));
        }
        this.jumping = false;
    }
}
