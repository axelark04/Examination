using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using TMPro; 
 
public class CrystalManager : MonoBehaviour 
{ 
    [SerializeField] TextMeshProUGUI crystalText; 
    public int crystalCount; 
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created 
    void Start() 
    { 
       
    } 
 
    // Update is called once per frame 
    void Update() 
    { 
        crystalText.text = ": " + crystalCount.ToString(); 
    } 
}