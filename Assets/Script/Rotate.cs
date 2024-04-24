using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
 
public class Rotate : MonoBehaviour 
{ 
    public float rotationSpeed =5f; 
    public Vector3 finalRotation;
    private Vector3 initRotation;
    void Start()
    {
        initRotation = transform.localEulerAngles;
    }
    public BoxCollider2D myCollider;
 
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
            if (hit.collider == myCollider)
            {
                RotateObjectAroundZAxis();
            }
        }
        Debug.Log(transform.localEulerAngles.z+"Final Rotation = "+finalRotation.z);
    } 

    void OnMouseUp()
    {
        transform.localEulerAngles = initRotation;
    }
      
 
    public void RotateObjectAroundZAxis(){ 
 
        if(transform.localEulerAngles.z >= finalRotation.z){
            return;
        }
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime); 
 
    }
}