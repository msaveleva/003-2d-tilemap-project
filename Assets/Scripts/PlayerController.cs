using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
        // Debug.Log(Input.GetAxis("Horizontal"));
        // Debug.Log(Input.GetAxis("Vertical"));
        // Debug.Log("======");
        moveInput *= Time.deltaTime;

        if (!moveInput.Equals(Vector2.zero))
        {
            transform.Translate(new Vector3(moveInput.x, moveInput.y, 0));    
        }
        
        // transform.position += new Vector3(moveVelocity.x, moveVelocity.y, 0);
    }
}
