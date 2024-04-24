using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
 
public class Draggable : MonoBehaviour 
{ 
    Vector3 originalPosition; 
    Vector3 mousePositionOffSet; 
 
    private void Awake() { 
        originalPosition = transform.position; 
    } 
    private Vector3 GetMouseWorldPosition() 
    { 
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);   
    } 
 
    private void OnMouseDown()  
    { 
        mousePositionOffSet = gameObject.transform.position - GetMouseWorldPosition(); 
    } 
     
    private void OnMouseDrag() 
    { 
        transform.position = GetMouseWorldPosition() + mousePositionOffSet;  
    } 
 
    private void OnMouseUp() { 
        transform.position = originalPosition; 
    }
}