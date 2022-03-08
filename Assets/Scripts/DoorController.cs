using UnityEngine;

public class DoorController : MonoBehaviour
{
    // Animator component's property.
    private Animator animator;
    
    private BoxCollider2D boxCollider;
    private bool doorIsOpen = false;

    // Hash property suggested by Rider instead of plain using "shouldOpen" key in OnCollisionEnter2D method.
    private static readonly int ShouldOpen = Animator.StringToHash("shouldOpen");

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision detected!");

        if (!doorIsOpen)
        {
            Debug.Log("Opening the door.");
            animator.SetBool("shouldOpen", true);    
        }
        
        Debug.Log("Completing collision handling.");
    }
}