using System; 
using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.Events; 
public class UnityEventOnTrigger : MonoBehaviour 
{ 
    [Tooltip("The colliding object that we want to trigger these events with needs to use a tag of the same name as typed in this variable")] 
    public string tagToActivate = "Player"; 
    public UnityEvent onTriggerEnter, onTriggerExit; 
    private void OnTriggerEnter2D(Collider2D other) 
    { 
// Destroy the collectible 
        Destroy(gameObject); 
    } 
}