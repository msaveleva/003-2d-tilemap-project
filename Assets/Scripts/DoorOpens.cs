using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorOpens : MonoBehaviour
{
    // Animator component's property.
    private Animator animator;
    
    private bool doorIsOpen = false;
    
    // Hash property suggested by Rider instead of plain using "shouldOpen" key in OnCollisionEnter2D method.
    private static readonly int ShouldOpen = Animator.StringToHash("shouldOpen");
    
    // Start is called before the first frame update
    void Start()
    { 
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D other) {
        Debug.Log("Collision stay!");
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Collision enter!");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Entered trigger!");
        
        if (!doorIsOpen)
        {
            Debug.Log("Opening the door.");
            animator.SetBool("shouldOpen", true);
            
            // Loading the next scene after the door has been opened.
            // Ending the game.
            SceneManager.LoadScene("GameOver");

            doorIsOpen = true;
        }
        
        Debug.Log("Completing collision handling.");
    }
}
