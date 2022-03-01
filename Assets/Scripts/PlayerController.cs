using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;
    private RaycastHit2D hit;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        moveDelta = new Vector3(x, y, 0);
        
        // Swapping sprite's direction depending on input.
        if (moveDelta.x > 0)
        {
            transform.localScale = Vector3.one;
        } 
        else if (moveDelta.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        
        // Make sure we can move in this direction by casting the ray first.
        hit = Physics2D.BoxCast(
            transform.position, 
            boxCollider.size, 
            0, 
            new Vector2(0, moveDelta.y), 
            Mathf.Abs(moveDelta.y * Time.deltaTime), 
            LayerMask.GetMask("Player", "Collidables")
            );
        if (hit.collider == null)
        {
            // Movement implementation.
            transform.Translate(0, moveDelta.y * Time.deltaTime, 0);    
        }

        hit = Physics2D.BoxCast(
            transform.position,
            boxCollider.size,
            0,
            new Vector2(moveDelta.x, 0),
            Mathf.Abs(moveDelta.x * Time.deltaTime),
            LayerMask.GetMask("Player", "Collidables")
            );
        if (hit.collider == null)
        {
            // Movement implementation.
            transform.Translate(moveDelta.x * Time.deltaTime, 0, 0);
        }
    }
}
