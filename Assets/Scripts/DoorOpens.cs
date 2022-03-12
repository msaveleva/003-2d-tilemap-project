using System.Collections;
using System.Threading.Tasks;
using System.Timers;
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

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Entered trigger!");
        
        if (!doorIsOpen)
        {
            Debug.Log("Opening the door.");
            animator.SetBool("shouldOpen", true);

            // TODO: fix calling on the main thread.
            // Task.Delay(1000).ContinueWith(t => showGameOverOnMainThread());
            SceneManager.LoadScene("GameOver");
            
            doorIsOpen = true;
        }
        
        Debug.Log("Completing collision handling.");
    }
    
    
    /// Below are the possible solutions of running the method on the main thread (doesn't work for now).

    /// <summary>
    /// Executing game over scene presentation on the main thread.
    /// Open source class has been used for this way of presentation.
    /// </summary>
    private void showGameOverOnMainThread()
    {
        UnityMainThreadDispatcher.Instance().Enqueue(showGameOver());
    }

    private IEnumerator showGameOver()
    {
        Debug.Log("Loading game over sceen...");
        
        // Loading the next scene after the door has been opened.
        // Ending the game.
        SceneManager.LoadScene("GameOver");
        
        yield return null;
    }
}
