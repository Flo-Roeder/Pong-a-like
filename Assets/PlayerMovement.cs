using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] int moveSpeed;
    private Rigidbody2D playerRb;
    private float moveY, moveX;
    public bool player2;

    // Start is called before the first frame update
    void Start()
    {
        playerRb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player2)
        {
            moveY = Input.GetAxisRaw("Vertical2");
        }
        if (!player2)
        {
            moveY = Input.GetAxisRaw("Vertical");
            moveX = Input.GetAxisRaw("Horizontal");
            if (moveX!=0)
            {
                playerRb.constraints = RigidbodyConstraints2D.FreezeRotation;
            }
            if (moveX==0)
            {
                playerRb.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX;

            }
        }
    }

    private void FixedUpdate()
    {
        playerRb.velocity=new Vector2(moveSpeed*moveX,moveSpeed*moveY);
    }
}
