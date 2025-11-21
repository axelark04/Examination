using UnityEngine; 
using UnityEngine.InputSystem; 
public class KeyBindTest : MonoBehaviour 
{ 
    public InputActionAsset playerActions; 
    public Animator playerAnimations; 
    void Update() 
    { 
        if (playerActions.FindAction("Move").IsPressed()) 
        { 
            playerAnimations.SetBool("Walking", true); 
        } 
        else 
        { 
            playerAnimations.SetBool("Walking", false); 
        } 
    } 
}